using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private int colorButton;
    [SerializeField]
    private GameObject pointer;

    // Start is called before the first frame update
    void Start()
    {
        
        GetComponent<Renderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update() { 
        
            
        }


    //First Color Change (Random)
    public void colorChange()
    {
        /*GetComponent<Renderer>().material.color = Color.blue;
        colorButton--;
        Debug.Log("colorButton is = " + colorButton);*/

        GetComponent<Renderer>().material.color = new Color(Random.Range(10, 40), Random.Range(10, 40), Random.Range(10, 40));
    }

    /*public void colorChange2()
    {
        GetComponent<Renderer>().material.color = Color.red;
        colorButton++;
        Debug.Log("colorButton is = " + colorButton);
    }*/



    //Disable Ouline.cs
    public void disableOutline()
    {
        Debug.Log("Outline.cs Disabled");
        GetComponent<Outline>().enabled = false;
    }
}

  

