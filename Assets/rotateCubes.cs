using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class rotateCubes : MonoBehaviour
{
    [SerializeField] float rotSpeed;
    bool hover = false;
    Vector3 direction = Vector3.up;
    bool firstAxis = true;
    [SerializeField] TMP_Text axisText;

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
        if (OVRInput.Get(OVRInput.RawButton.A) && hover)
        {
            rotateCube();
        }
    }

    public void rotateCube()
    {
        transform.Rotate(direction * rotSpeed * Time.deltaTime);
    }

    public void changeRotAxis()
    {
        if (firstAxis)
        {
            direction = Vector3.left;
            axisText.SetText("Axis: X");
            firstAxis = false;
        }
        else if (firstAxis == false)
        {
            direction = Vector3.up;
            axisText.SetText("Axis: Y");
            firstAxis = true;
        }
    }

    

}
