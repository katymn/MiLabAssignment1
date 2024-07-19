using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    bool colorSelect = false;
    GameObject particleColor;
    [SerializeField] GameObject lollipopSphere;
    bool hover = false;

    public void hoverToggle()
    {
        hover = true;
    }

    public void hoverUntoggle()
    {
        hover = false;
    }

    public void Update()
    {

        if (OVRInput.GetDown(OVRInput.RawButton.A) && hover)
        {
            lollipopSphere.GetComponent<Renderer>().material.color = new Color(Random.Range(0, 226 / 255f), Random.Range(0, 226 / 255f), Random.Range(0, 226 / 255f));
        }

    }

    public void disableOutline()
    {
        Debug.Log("Outline.cs Disabled");
        GetComponent<Outline>().enabled = false;
        GetComponent<ChangeColor>().enabled = false;
        hover = false;
    }
}

  

