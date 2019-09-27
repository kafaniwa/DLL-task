using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
public class SimplePluginTest : MonoBehaviour
{
    const string DLL_NAME = "TESTPLUGIN";
    [DllImport(DLL_NAME)]
    private static extern void SimpleSaveFunction(float x, float y, float z);
    [DllImport(DLL_NAME)]
    private static extern float SimpleLoadFunctionX();
    [DllImport(DLL_NAME)]
    private static extern float SimpleLoadFunctionY();
    [DllImport(DLL_NAME)]
    private static extern float SimpleLoadFunctionZ();
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {

            SimpleSaveFunction(transform.position.x, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            
            transform.position = new Vector3(SimpleLoadFunctionX(), 0.5f, SimpleLoadFunctionZ());
        }
    }
}
