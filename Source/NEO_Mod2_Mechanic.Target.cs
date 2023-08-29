// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class NEO_Mod2_MechanicTarget : TargetRules
{
	public NEO_Mod2_MechanicTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("NEO_Mod2_Mechanic");
	}
}
