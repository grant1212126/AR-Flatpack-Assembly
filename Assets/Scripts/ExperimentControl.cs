using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperimentControl : MonoBehaviour
{

    public GameObject Client;

    public GameObject DebugLogWindow;
    
    public GameObject OVRManager;
    public GameObject OVRRig;



    private bool CheckPlatformAndroid()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            Debug.Log("Android Build Detected");
            return true;

        } else
        {
            Debug.Log("Android Build Not Detected.....");
            return false;
        }
            
    }

    public void EnableDebugLogWindow()
    {
        if (DebugLogWindow.active)
        {
            DebugLogWindow.SetActive(false);
        }
        else
        {
            DebugLogWindow.SetActive(true);
        }
    }

    public void printHelloWorld()
    {
        Debug.Log("Hello World");
    }

    // Start is called before the first frame update
    void Start()
    {
        if (CheckPlatformAndroid()) {
            
        } else
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
