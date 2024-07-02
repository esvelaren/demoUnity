using UnityEditor;

public class BuildScript
{
static void BuildWindows()
    {
        // Add all scenes
        string[] scenes = { "Assets/Scenes/SampleScene.unity" };
        // Build for windows
        BuildPipeline.BuildPlayer(scenes, "../WindowsBuild/Practice.exe", BuildTarget.StandaloneWindows, BuildOptions.None);
    }
}
