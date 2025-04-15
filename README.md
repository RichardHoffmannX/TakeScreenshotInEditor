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
