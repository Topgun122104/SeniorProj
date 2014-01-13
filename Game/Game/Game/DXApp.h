#pragma once
#include <windows.h>
#include <string>
#include "DXUtil.h"


class DXApp
{
public:
	DXApp(HINSTANCE hInstance);
	virtual ~DXApp(void);

	// Main application Loop
	int Run();

	// Framework Methods
	virtual bool Initialize();
	virtual void Update(float dt) = 0; // when set to 0, they NEED to be overridden 
	virtual void Draw(float dt) = 0;
	virtual LRESULT MsgProc(HWND hwnd, UINT msg, WPARAM wPAram, LPARAM lParam);

protected:

	// Win32 Attributes
	HWND		m_hAppWnd;
	HINSTANCE	m_hAppInstance;
	UINT		m_ClientWidth;
	UINT		m_ClientHeight;
	std::string	m_AppTitle;
	DWORD		m_WndStyle;

	// DirectX Attributes
	ID3D11Device*				m_pDevice;
	ID3D11DeviceContext*		m_pImmediateContext;
	IDXGISwapChain*				m_pSwapChain;
	ID3D11RenderTargetView*		m_pRenderTargetView;
	D3D_DRIVER_TYPE				m_DriverType;
	D3D_FEATURE_LEVEL			m_FeatureLevel;
	D3D11_VIEWPORT				m_Viewport;


protected:
	//Initialize the Win 32 window
	bool InitWindow();

	//Initialize Direct3D
	bool InitDirect3D();


};

