using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeDetectionMaster : MonoBehaviour {

    //private List<Object> buildings;
    // public GameObject Cti
    // Use this for initialization
    private float DegToRad(float deg)
    {
        return 3.141592653589793f * deg / 180;
    }
    public Camera camera;
    public Light light;
	void Start ()
    {
     

    }

    // Update is called once per frame
    void Update () 
    {
        if (Input.GetKeyDown("space"))
        {
            //startup
            Debug.Log("I am alive!");
            
            camera.transform.position = new Vector3(-2422.714f, 100000f, 150f);
            camera.transform.rotation = Quaternion.Euler(90, 0, 0);
            //ScreenCapture.CaptureScreenshot("Screenshot.png", 2);
            Debug.Log(camera.transform.position);
            Debug.Log(camera.transform.rotation.eulerAngles);
            
            camera.fieldOfView = 2.3f;
            camera.nearClipPlane = 10000f;
            camera.farClipPlane = 1000000;

       
            TakeScreenshot("1.png");

            camera.transform.position = new Vector3(-2422.714f, 100000f, 26945.91f);
            camera.transform.rotation = Quaternion.Euler(105, 0, 0);
            

            /*light.transform.position = new Vector3(-476, 100000, 768);
            light.transform.rotation = Quaternion.Euler(27.87f, -27.41f, 14.297f);
            light.intensity = 0.86f;
            light.color = new Color(0xFF, 0xE9, 0xD6, 0xFF);*/

            TakeScreenshot("2.png");

            camera.transform.position = new Vector3(-2422.714f, 100000f, -26645.91f);
            camera.transform.rotation = Quaternion.Euler(75, 0, 0);
            

            /*light.transform.position = new Vector3(10000, 100000, 768);
            light.transform.rotation = Quaternion.Euler(137.548f, -45.10797f, -16.98599f);
            light.intensity = 1.3f;
            light.color = new Color(0xFF, 0xE6, 0xD6, 0xFF);*/

            TakeScreenshot("3.png");

            camera.transform.position = new Vector3(-2422.714f + 26795.91f, 100000f, 150);
            camera.transform.rotation = Quaternion.Euler(105, 90, 90);


            /*light.transform.position = new Vector3(-476, 100000, 768);
            light.transform.rotation = Quaternion.Euler(27.87f, -27.41f, 14.297f);
            light.intensity = 0.86f;
            light.color = new Color(0xFF, 0xE9, 0xD6, 0xFF);*/

            TakeScreenshot("4.png");

            camera.transform.position = new Vector3(-2422.714f - 26795.91f, 100000f, 150);
            camera.transform.rotation = Quaternion.Euler(75, 90, 90);

            /*light.transform.position = new Vector3(10000, 100000, 768);
            light.transform.rotation = Quaternion.Euler(137.548f, -45.10797f, -16.98599f);
            light.intensity = 1.3f;
            light.color = new Color(0xFF, 0xE6, 0xD6, 0xFF);*/

            TakeScreenshot("5.png");
            //ScreenCapture.CaptureScreenshot("Screenshot2.png", 2);

            Debug.Log("I have finished!");
        }

        if (Input.GetKeyDown("down"))
        {
            
        }

    }


    private void TakeScreenshot(string filename)
    {
        int resWidth = 5000;
        int resHeight = 5000;
        RenderTexture rt = new RenderTexture(resWidth, resHeight, 24);
        camera.targetTexture = rt;
        Texture2D screenShot = new Texture2D(resWidth, resHeight, TextureFormat.RGB24, false);
        camera.Render();
        RenderTexture.active = rt;
        screenShot.ReadPixels(new Rect(0, 0, resWidth, resHeight), 0, 0);
        camera.targetTexture = null;
        RenderTexture.active = null; // JC: added to avoid errors
        Destroy(rt);
        byte[] bytes = screenShot.EncodeToPNG();
        System.IO.File.WriteAllBytes(filename, bytes);
    }

}
