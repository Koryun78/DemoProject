// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class DemoProject : ModuleRules
{
	public DemoProject(ReadOnlyTargetRules Target) : base(Target)
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
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"DemoProject",
			"DemoProject/Variant_Platforming",
			"DemoProject/Variant_Platforming/Animation",
			"DemoProject/Variant_Combat",
			"DemoProject/Variant_Combat/AI",
			"DemoProject/Variant_Combat/Animation",
			"DemoProject/Variant_Combat/Gameplay",
			"DemoProject/Variant_Combat/Interfaces",
			"DemoProject/Variant_Combat/UI",
			"DemoProject/Variant_SideScrolling",
			"DemoProject/Variant_SideScrolling/AI",
			"DemoProject/Variant_SideScrolling/Gameplay",
			"DemoProject/Variant_SideScrolling/Interfaces",
			"DemoProject/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
