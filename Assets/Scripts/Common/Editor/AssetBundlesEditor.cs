﻿using UnityEngine;

public class AssetBundlesEditor : EditorWindow
    #region 创建AB包
    public static void BuildiPhoneResource()
    {
        BuildTarget target;
        target = BuildTarget.iOS;
        BuildAssetResource(target);
    }
    [MenuItem("AB包工具/打AB包/Build Android AB包", false, 2)]
    public static void BuildAndroidResource()
    {
        BuildAssetResource(BuildTarget.Android);
    }
    [MenuItem("AB包工具/打AB包/Build WebGL AB包", false, 4)]
    public static void BuildWebGLResource()
    {
        BuildAssetResource(BuildTarget.WebGL);
    }
    [MenuItem("AB包工具/打AB包/Build Wins AB包/将一个或者多个文件打成一个包", false, 1)]
    public static void BuildWindowsResource()
    {
        _ABStoragePath = HMLFramwork.Helpers.PathHelper.getAssetsBundlePath;
        buildTarget = BuildTarget.StandaloneWindows64;
        EditorWindow.GetWindow(typeof(AssetBundlesEditor), true, "AB包打包工具");
    }
    [MenuItem("AB包工具/清除所有设置过的AssetBundleName")]
    static void ClearAllAssetBundlesName()
    }
    private static void BuildAssetResource(BuildTarget _target)
    {
        if (_ABStoragePath.Length <= 0 || !Directory.Exists(_ABStoragePath)) return;
    }
    #endregion

    private void OnGUI()
    {
        GUILayout.Label("AB包的名字（当没有赋值时，默认使用选中的第一个对象的名字）：");
    void OnInspectorUpdate()
}