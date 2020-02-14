using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialSample : MonoBehaviour
{
    private AndroidJavaObject javaClass;
    // Start is called before the first frame update
    void Start()
    {
        javaClass = new AndroidJavaObject("com.example.android.mqttlibrary.Helper");
        javaClass.Call("LogNative");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
