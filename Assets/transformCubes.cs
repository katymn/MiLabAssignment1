using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;
using TMPro;

public class transformCubes : MonoBehaviour
{
    [SerializeField] float posSpeed;
    bool hover = false;
    int firstAxis = 0;
    Vector3 direction = Vector3.up;
    [SerializeField] TMP_Text axisText;

    public void hoverToggle()
    {
        hover = true;
    }

    public void hoverUntoggle()
    {
        hover = false;
    }


    void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.A) && hover)
        {
            positionCube();
        }

    }

    public void positionCube()
    { 
        transform.Translate(direction * posSpeed * Time.deltaTime);
    }

    public void changeTransAxis()
    {
        if (firstAxis == 0)
        {
            direction = new Vector3(1, 0, 0);
            axisText.SetText("Axis: X");
            firstAxis++;
        }
        else if (firstAxis == 1)
        {
            direction = Vector3.up;
            axisText.SetText("Axis: Y");
            firstAxis++;
        }
        else if (firstAxis == 2)
        {
            direction = new Vector3(0, 0, 1);
            axisText.SetText("Axis: Z");
            firstAxis = 0;
        }

    }
}

