// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class QTaskExample : ModuleRules
{
	public QTaskExample(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate",
			"GameplayAbilities",
			"IQT"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"QTaskExample",
			"QTaskExample/Variant_Platforming",
			"QTaskExample/Variant_Platforming/Animation",
			"QTaskExample/Variant_Combat",
			"QTaskExample/Variant_Combat/AI",
			"QTaskExample/Variant_Combat/Animation",
			"QTaskExample/Variant_Combat/Gameplay",
			"QTaskExample/Variant_Combat/Interfaces",
			"QTaskExample/Variant_Combat/UI",
			"QTaskExample/Variant_SideScrolling",
			"QTaskExample/Variant_SideScrolling/AI",
			"QTaskExample/Variant_SideScrolling/Gameplay",
			"QTaskExample/Variant_SideScrolling/Interfaces",
			"QTaskExample/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
