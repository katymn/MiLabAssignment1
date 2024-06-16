using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public float rotSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void rotate()
    { 
            Debug.Log("Rotating");
            transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);
  
    }

    public void stopRotate()
    {
        Debug.Log("Rotating");
        transform.Rotate(Vector3.up * 0 * Time.deltaTime);

    }


    public void disableOutline()
    {
        Debug.Log("Outline.cs Disabled");
        GetComponent<Outline>().enabled = false;
    }
}
