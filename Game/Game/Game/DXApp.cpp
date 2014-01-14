#include "DXApp.h"

namespace
{
	//used to forward msgs to user defined proc function
	DXApp* g_pApp = nullptr;
}

LRESULT CALLBACK MainWndProc(HWND hwnd, UINT msg, WPARAM wParam, LPARAM lParam)
{
	if (g_pApp)
	{
		return g_pApp->MsgProc(hwnd, msg, wParam, lParam);
	}
	else
	{
		return DefWindowProc(hwnd, msg, wParam, lParam);
	}
}

DXApp::DXApp(HINSTANCE hInstance)
{
	// Default settings for the window
	// can be overridden in the Game.cpp
	m_hAppInstance = hInstance;
	m_hAppWnd = NULL;
	m_ClientWidth = 640;
	m_ClientHeight = 480;
	m_AppTitle = "Empty Window";
	m_WndStyle = WS_OVERLAPPEDWINDOW;
	g_pApp = this;
	
	m_pDevice = nullptr;
	m_pImmediateContext = nullptr;
	m_pRenderTargetView = nullptr;
	m_pSwapChain = nullptr;
}


DXApp::~DXApp()
{
	// cleanup Direct3D
	if(m_pImmediateContext)
	{
		m_pImmediateContext->ClearState();
	}
	Memory::SafeRelease(m_pRenderTargetView);
	Memory::SafeRelease(m_pSwapChain);
	Memory::SafeRelease(m_pImmediateContext);
	Memory::SafeRelease(m_pDevice);
}

int DXApp::Run()
{
	MSG msg = { 0 };
	while (WM_QUIT != msg.message)
	{

		if (PeekMessage(&msg, NULL, NULL, NULL, PM_REMOVE))
		{
			TranslateMessage(&msg);
			DispatchMessage(&msg);
		}
		else
		{
			Update(0.0f);
			Draw(0.0f);
		}
	}
	return static_cast<int>(msg.wParam);
}

bool DXApp::Initialize()
{
	if(!InitWindow())
	{
		return false;
	}

	if(!InitDirect3D())
	{
		return false;
	}

	return true;
}


bool DXApp::InitWindow()
{
	// lots of crazy windows stuff here.
	WNDCLASSEX wcex;
	ZeroMemory(&wcex, sizeof(WNDCLASSEX));
	wcex.cbClsExtra = 0;
	wcex.cbWndExtra = 0;
	wcex.cbSize = sizeof(WNDCLASSEX);
	wcex.style = CS_HREDRAW | CS_VREDRAW;
	wcex.hInstance = m_hAppInstance;
	wcex.lpfnWndProc = MainWndProc;

	wcex.hCursor = LoadCursor(NULL, IDC_ARROW);
	wcex.hbrBackground = (HBRUSH)GetStockObject(NULL_BRUSH);
	wcex.lpszMenuName = NULL;
	wcex.lpszClassName = "DXAPPWNDCLASS";
	// the icon for the application
	// it is currently set to the default, 
	// we can change this.
	wcex.hIcon = LoadIcon(NULL, IDI_APPLICATION);
	wcex.hIconSm = LoadIcon(NULL, IDI_APPLICATION);

	if (!RegisterClassEx(&wcex))
	{
		OutputDebugString("\nFAILED TO CREATE WINDOW CLASS\n");
		return false;
	}

	// creates a rect for the display window to be offset 
	// so there is room for the frame
	RECT r = { 0, 0, m_ClientWidth, m_ClientHeight };
	AdjustWindowRect(&r, m_WndStyle, false);
	UINT width = r.right - r.left;
	UINT height = r.bottom - r.top;

	// sets the center of the window,
	// so it is displayed in the center of the screen.
	UINT x = GetSystemMetrics(SM_CXSCREEN) / 2 - width / 2;
	UINT y = GetSystemMetrics(SM_CYSCREEN) / 2 - height / 2;

	m_hAppWnd = CreateWindow("DXAPPWNDCLASS", m_AppTitle.c_str(), m_WndStyle,
		x, y, width, height, NULL, NULL, m_hAppInstance, NULL);

	if (!m_hAppWnd)
	{
		OutputDebugString("\nFAILED TO CREATE WINDOW\n");
		return false;
	}

	// actually displays the window 
	ShowWindow(m_hAppWnd, SW_SHOW);

	return true;
}

bool DXApp::InitDirect3D()
{
	UINT createDeviceFlags = 0;

#ifdef _DEBUG
	createDeviceFlags |= D3D11_CREATE_DEVICE_DEBUG;
#endif	//_DEBUG

	D3D_DRIVER_TYPE driverTypes[] = 
	{
		D3D_DRIVER_TYPE_HARDWARE,	// uses this if there is a graphics card(preferred)
		D3D_DRIVER_TYPE_WARP,		// if you dont have a graphics card
		D3D_DRIVER_TYPE_REFERENCE	// for development
	};

	UINT numDriverTypes = ARRAYSIZE(driverTypes);

	D3D_FEATURE_LEVEL featureLevels[] = 
	{
		D3D_FEATURE_LEVEL_11_0,	// preferred
		D3D_FEATURE_LEVEL_10_1,
		D3D_FEATURE_LEVEL_10_0,
		D3D_FEATURE_LEVEL_9_3
	};

	UINT numFeatureLevels = ARRAYSIZE(featureLevels);

	DXGI_SWAP_CHAIN_DESC swapDesc;
	ZeroMemory(&swapDesc, sizeof(DXGI_SWAP_CHAIN_DESC));
	swapDesc.BufferCount = 1; // double buffered
	swapDesc.BufferDesc.Width = m_ClientWidth;
	swapDesc.BufferDesc.Height = m_ClientHeight;
	swapDesc.BufferDesc.Format = DXGI_FORMAT_R8G8B8A8_UNORM; // 32 bit
	swapDesc.BufferDesc.RefreshRate.Numerator = 60;		// 60 frames/ sec
	swapDesc.BufferDesc.RefreshRate.Denominator = 1;
	swapDesc.BufferUsage = DXGI_USAGE_RENDER_TARGET_OUTPUT;
	swapDesc.OutputWindow = m_hAppWnd;
	swapDesc.SwapEffect = DXGI_SWAP_EFFECT_DISCARD;
	swapDesc.Windowed = true;
	swapDesc.SampleDesc.Count = 1;
	swapDesc.SampleDesc.Quality = 0;
	// currently does not resize the buffer
	swapDesc.Flags = DXGI_SWAP_CHAIN_FLAG_ALLOW_MODE_SWITCH;  // alt-enter goes fullscreen

	HRESULT result;
	for (int i = 0; i < numDriverTypes; i++)
	{
		result = D3D11CreateDeviceAndSwapChain(NULL, driverTypes[i], NULL, createDeviceFlags,
			featureLevels, numFeatureLevels, D3D11_SDK_VERSION, &swapDesc, &m_pSwapChain, &m_pDevice, 
			&m_FeatureLevel, &m_pImmediateContext);

		// if the result succeeded, 
		// set the drive to the driver type it passed on
		if(SUCCEEDED(result))
		{
			m_DriverType = driverTypes[i];
			break;
		}

	}

	// if the result failed, exit.
	if(FAILED(result))
	{
		OutputDebugString("Failed to device and swap chain");
		return false;
	}

	// create render target view
	ID3D11Texture2D* m_pBackBufferTex = 0;
	m_pSwapChain->GetBuffer(NULL, __uuidof(ID3D11Texture2D), reinterpret_cast<void**>(&m_pBackBufferTex));
	m_pDevice->CreateRenderTargetView(m_pBackBufferTex, nullptr, &m_pRenderTargetView);
	Memory::SafeRelease(m_pBackBufferTex);


	// bind the render target view
	m_pImmediateContext->OMSetRenderTargets(1, &m_pRenderTargetView, nullptr);

	// create the viewport
	m_Viewport.Width = m_ClientWidth;
	m_Viewport.Height = m_ClientHeight;
	m_Viewport.TopLeftX = 0;
	m_Viewport.TopLeftY = 0;
	m_Viewport.MinDepth = 0.0f;
	m_Viewport.MaxDepth = 1.0f;

	// bind the viewport
	m_pImmediateContext->RSSetViewports(1, &m_Viewport);
	

	return true;


}

LRESULT DXApp::MsgProc(HWND hwnd, UINT msg, WPARAM wPAram, LPARAM lParam)
{
	// messages so it closes the application when the
	// window is closed out.
	switch (msg)
	{
	case WM_DESTROY:
		PostQuitMessage(0);
		return(0);

	default:
		return DefWindowProc(hwnd, msg, wPAram, lParam);
	}
}

