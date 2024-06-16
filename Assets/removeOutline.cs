using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeOutline : MonoBehaviour
{
    public void disableOutline()
    {
        Debug.Log("Outline.cs Disabled");
        GetComponent<Outline>().enabled = false;
    }
}
