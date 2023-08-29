// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

#include "NEO_Mod2_MechanicGameMode.h"
#include "NEO_Mod2_MechanicHUD.h"
#include "NEO_Mod2_MechanicCharacter.h"
#include "UObject/ConstructorHelpers.h"

ANEO_Mod2_MechanicGameMode::ANEO_Mod2_MechanicGameMode()
	: Super()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnClassFinder(TEXT("/Game/FirstPersonCPP/Blueprints/FirstPersonCharacter"));
	DefaultPawnClass = PlayerPawnClassFinder.Class;

	// use our custom HUD class
	HUDClass = ANEO_Mod2_MechanicHUD::StaticClass();
}
