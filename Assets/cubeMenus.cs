using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMenus : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    [SerializeField] GameObject transformCanvas;

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.B))
        {
            canvas.SetActive(true);
            Debug.Log("canvas enabled");
        }
    }

    public void activateTransformMenu()
    {
        transformCanvas.SetActive(true);
    }

}
