#pragma once
#include <windows.h>
#include "DXApp.h"


class Game : public DXApp
{
public:
	Game(HINSTANCE hInstance);
	~Game();

	bool Initialize() override;
	void Update(float dt) override;
	void Draw(float dt) override;

};

