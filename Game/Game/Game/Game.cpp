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
	


}

// This is the Draw method for the game loop
void Game::Draw(float dt)
{



}
