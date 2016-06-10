using UnityEngine;
using UnityEditor;
using System.Collections;

public class BuildScript : MonoBehaviour {

    static string[] scenes = {
        "Assets/funville.unity"
    };


    [MenuItem("Build/StandaloneWindows32")]
    static void StandaloneWindows32()
    {
        BuildPipeline.BuildPlayer(scenes, "Build/StandaloneWindows32/StandaloneWindows32.exe", BuildTarget.StandaloneWindows, BuildOptions.None);
    }

    [MenuItem ("Build/StandaloneWindows64")]
    static void StandaloneWindows64()
    {
        BuildPipeline.BuildPlayer(scenes, "Build/StandaloneWindows64/StandaloneWindows64.exe", BuildTarget.StandaloneWindows64, BuildOptions.None);
    }

    [MenuItem("Build/StandaloneOSXIntel")]
    static void StandaloneOSXIntel()
    {
        BuildPipeline.BuildPlayer(scenes, "Build/StandaloneOSXIntel/StandaloneOSXIntel.exe", BuildTarget.StandaloneOSXIntel, BuildOptions.None);
    }

    [MenuItem("Build/StandaloneOSXIntel64")]
    static void StandaloneOSXIntel64()
    {
        BuildPipeline.BuildPlayer(scenes, "Build/StandaloneOSXIntel64/StandaloneOSXIntel64.exe", BuildTarget.StandaloneOSXIntel64, BuildOptions.None);
    }

    [MenuItem("Build/StandaloneOSXUniversal")]
    static void StandaloneOSXUniversal()
    {
        BuildPipeline.BuildPlayer(scenes, "Build/StandaloneOSXUniversal/StandaloneOSXUniversal.exe", BuildTarget.StandaloneOSXUniversal, BuildOptions.None);
    }

    [MenuItem("Build/All")]
    static void All()
    {
        //Windows Builds
        StandaloneWindows32();
        StandaloneWindows64();

        //Mac Builds
        //StandaloneOSXIntel();
        //StandaloneOSXIntel64();
        //StandaloneOSXUniversal();
    }




}
