using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor.iOS.Xcode;

public static class BuildScript
{
	[MenuItem("Build/Build")]
	public static void Build()
	{
		var scenes = EditorBuildSettings.scenes;
		List<string> sceneList = new List<string>();
		foreach (var scene in scenes)
		{
			if (scene.enabled)
				sceneList.Add(scene.path);
		}
		var sceneArray = sceneList.ToArray();

		var dst = Path.Combine (new DirectoryInfo(Application.dataPath).Parent.Parent.FullName, "build");
		BuildPipeline.BuildPlayer (sceneArray,  dst, BuildTarget.iOS, BuildOptions.Development);
		//string projPath = PBXProject.GetPBXProjectPath(dst);
	}
}
