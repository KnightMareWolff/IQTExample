// Copyright Epic Games, Inc. All Rights Reserved.

#include "QTaskExampleGameMode.h"

AQTaskExampleGameMode::AQTaskExampleGameMode()
{
	// stub
	// This code will execute after your module is loaded into memory; the exact timing is specified in the .uplugin file per-module
    UAbilitySystemGlobals::Get().InitGlobalData();

}
