using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperimentControl : MonoBehaviour
{

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

    public void printHelloWorld()
    {
        Debug.Log("Hello World");
    }

    // Start is called before the first frame update
    void Start()
    {
        CheckPlatformAndroid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
