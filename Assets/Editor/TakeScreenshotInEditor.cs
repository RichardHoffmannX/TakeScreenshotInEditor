#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

public class TakeScreenshotInEditor : ScriptableObject
{
	public static string fileName = "Editor Screenshot ";
    public static int startNumber = 1;

	[MenuItem ("Custom/Take Screenshot of Game View %^t")]
	static void TakeScreenshot()
	{
		int number = startNumber;
		string name = "" + number;

        string fileNameFull = fileName + name + ".png";

        while (System.IO.File.Exists(fileNameFull))
		{
			number++;
			name = "" + number;
		}

		startNumber = number + 1;

		ScreenCapture.CaptureScreenshot(fileNameFull);

		Debug.Log($"TakeScreenshotInEditor: {fileNameFull}");
		Application.OpenURL("file://" + Application.dataPath.Replace("Assets", ""));
	}
}
#endif