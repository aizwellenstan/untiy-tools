using UnityEngine;
using System.Collections;
using UnityEditor;
using System.IO;


public class ExportAssetBundle
{
    [MenuItem("Export/AssetBundle")]
    static void Export()
    {
        Directory.CreateDirectory(Application.streamingAssetsPath);
        // BuildPipeline.BuildAssetBundles(Application.streamingAssetsPath);
        BuildPipeline.BuildAssetBundles(Application.streamingAssetsPath, 0, BuildTarget.Android);
    }
}