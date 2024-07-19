using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField]
    GameObject particles;
    bool hover = false;
    bool up;

    public void hoverToggle()
    {
        hover = true;
    }

    public void hoverUntoggle()
    {
        hover = false;
    }

    public void upToggle()
    {
        up = true;
    }

    public void downToggle()
    {
        up = false;
    }


    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.A) && hover && up)
        {
            transform.localScale *= 1.1f;
        }
        else if (OVRInput.GetDown(OVRInput.RawButton.A) && hover && (up == false))
        {
            transform.localScale *= 0.9f;
        }
    }

    public void changeScale()
    {
        if (OVRInput.Get(OVRInput.RawButton.X))
        {
            transform.localScale *= 1.1f;
            particles.SetActive(true);
        }
    }

    //Disable Ouline.cs
    public void disableOutline()
    {
        Debug.Log("Outline.cs Disabled");
        GetComponent<Outline>().enabled = false;
        particles.SetActive(false);
        hover = false;
    }
}
