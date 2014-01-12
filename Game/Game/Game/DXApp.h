#pragma once
#include <windows.h>
#include <string>


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

protected:
	//Initialize the Win 32 window
	bool InitWindow();

};

