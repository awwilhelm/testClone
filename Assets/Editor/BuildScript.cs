using UnityEngine;
using UnityEditor;
using System.Collections;

public class BuildScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    [MenuItem ("Build/BuildWebplayer")]
    static void MyBuild()
    {
        string[] scenes = { "Assets/funville.unity" };
        BuildPipeline.BuildPlayer(scenes, "Build/name.exe", BuildTarget.StandaloneWindows64, BuildOptions.None);

    }

}
