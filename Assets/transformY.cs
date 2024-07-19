using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformY : MonoBehaviour
{
    public float speed = 2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
            if (OVRInput.Get(OVRInput.RawButton.X))
            {
                Debug.Log("Moving Up");
                transform.Translate(Vector3.up * speed * Time.deltaTime);
                //GetComponent<AudioSource>().Play();
            }

    }



    //Disable Ouline.cs
        public void disableOutline()
    {
        Debug.Log("Outline.cs Disabled");
        GetComponent<Outline>().enabled = false;
        GetComponent<transformY>().enabled = false;
    }
}
  
