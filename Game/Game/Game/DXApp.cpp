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
}


DXApp::~DXApp()
{
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
	return InitWindow();
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

