using UnrealBuildTool;

public class PicnicCore : ModuleRules
{
   public PicnicCore(ReadOnlyTargetRules Target) : base(Target)
   {
       PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

       PublicDependencyModuleNames.AddRange( new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
       PrivateDependencyModuleNames.AddRange( new string[] { } );
   }
}
