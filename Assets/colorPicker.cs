using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class colorPicker : MonoBehaviour
{
    [SerializeField] GameObject obj1;
    [SerializeField] GameObject obj2;
    bool obj1Selected = false;
    bool obj2Selected = false;
    bool hover1 = false;
    bool hover2 = false;

    void Update()
    {
        if (hover1)
        {
            colorPicker1();
            applyColor2();
        }
        else if (hover2)
        {
            colorPicker2();
            applyColor1();
        }
    }

    public void enableHover1()
    {hover1 = true; hover2 = false; }

    public void enableHover2()
    { hover2 = true; hover1 = false; }

    //Apply to object1
    public void colorPicker1()
    {
        if (OVRInput.Get(OVRInput.RawButton.X) && obj2Selected == false)
        {
            obj1Selected = true;
        }
    }

    public void applyColor2()
    {
        if (OVRInput.Get(OVRInput.RawButton.Y) && obj2Selected)
        {
            obj2Selected = false;
            obj1.GetComponent<Renderer>().material = obj2.GetComponent<Renderer>().material;
        }
    }



    //Apply to object 2
    public void colorPicker2()
    {
        if (OVRInput.Get(OVRInput.RawButton.X) && obj1Selected == false)
        {
            obj2Selected = true;
        }
    }

    public void applyColor1()
    {
        if (OVRInput.Get(OVRInput.RawButton.Y) && obj1Selected)
        {
            obj2.GetComponent<Renderer>().material = obj1.GetComponent<Renderer>().material;
            obj1Selected = false;
        }
    }
}
