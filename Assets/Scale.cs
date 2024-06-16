using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeScale()
    {
            transform.localScale *= 1.1f;
    }

    //Disable Ouline.cs
    public void disableOutline()
    {
        Debug.Log("Outline.cs Disabled");
        GetComponent<Outline>().enabled = false;
    }
}
