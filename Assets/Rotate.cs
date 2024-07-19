using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float rotSpeed = 10;
    [SerializeField]

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.X))
        {
            Debug.Log("Rotating");
            transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);
            GetComponent<AudioSource>().Play();
        }
    }

    public void stopRotate()
    {
        Debug.Log("Stop Rotating");
        transform.Rotate(Vector3.up * 0 * Time.deltaTime);
        GetComponent<Rotate>().enabled = false;
    }


    public void disableOutline()
    {
        Debug.Log("Outline.cs Disabled");
        GetComponent<Outline>().enabled = false;
        GetComponent<AudioSource>().Stop();
    }
}
