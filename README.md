# TakeScreenshotInEditor
TakeScreenshotInEditor for Unity inside the Editor

Source:
https://docs.unity3d.com/6000.0/Documentation/ScriptReference/ScreenCapture.CaptureScreenshot.html

```
using UnityEngine;

// Generate a screenshot and save it to disk with the name SomeLevel.png.

public class ExampleScript : MonoBehaviour
{
    void OnMouseDown()
    {
        ScreenCapture.CaptureScreenshot("SomeLevel.png");
    }
}
```

Here an example for the Unity Editor with CTRL + T Shortcut:

```
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

        	// Show in Console
		Debug.Log($"TakeScreenshotInEditor: {fileNameFull}");

		// Show in Windows Explorer etc
		Application.OpenURL("file://" + Application.dataPath.Replace("Assets", ""));
	}
}
#endif
```
