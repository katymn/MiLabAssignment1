using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    [SerializeField] GameObject transformCanvas;

    public void exitMenus()
    {
        canvas.SetActive(false);
        GetComponent<cubeMenus>().enabled = false;
        transformCanvas.SetActive(false);
    }

    public void noActionActivate()
    {
        GetComponent<transformCubes>().enabled = false;
        GetComponent<rotateCubes>().enabled = false;
    }

    public void noActionActivateSphere()
    {
        GetComponent<Scale>().enabled = false;
        GetComponent<ChangeColor>().enabled = false;
    }

    

}
