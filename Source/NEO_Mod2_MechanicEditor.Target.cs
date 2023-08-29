// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class NEO_Mod2_MechanicEditorTarget : TargetRules
{
	public NEO_Mod2_MechanicEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		ExtraModuleNames.Add("NEO_Mod2_Mechanic");
	}
}
