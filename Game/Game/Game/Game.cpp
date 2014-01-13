#include "Game.h"

Game::Game(HINSTANCE hInstance) : DXApp(hInstance)
{
	// Settings for the game window
	DXApp::m_ClientWidth = 1280;
	DXApp::m_ClientHeight = 720;
	DXApp::m_AppTitle = "Game";
}

Game::~Game()
{
}


bool Game::Initialize()
{
	return DXApp::Initialize();
}

// This is the Update method for the game loop
void Game::Update(float dt)
{
	


	// clears and refreshes the window
	m_pImmediateContext->ClearRenderTargetView(m_pRenderTargetView, DirectX::Colors::Green);
	m_pSwapChain->Present(0, 0);

}

// This is the Draw method for the game loop
void Game::Draw(float dt)
{



}
