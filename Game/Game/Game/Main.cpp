#include <windows.h>
#include "Game.h"


int WINAPI WinMain( __in HINSTANCE hInstance, __in_opt HINSTANCE hPrevInstance, __in LPSTR lpCmdLine, __in int nShowCmd)
{
	// Creates a new instance of a game.
	Game game(hInstance);
	// if the game window isn't initialized,
	// don't run the game.
	if (!game.Initialize())
	{
		return (1);
	}

	// run the game
	return game.Run();
	return (0);

}