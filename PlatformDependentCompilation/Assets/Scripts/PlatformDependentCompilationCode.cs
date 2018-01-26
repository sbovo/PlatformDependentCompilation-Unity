using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDependentCompilationCode : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
#if NETFX_CORE
        Debug.Log("Execution in UWP");
#endif
#if UNITY_EDITOR
        Debug.Log("Execution in Unity Editor");
#endif
    }

    // Update is called once per frame
    void Update () {

    }
}
