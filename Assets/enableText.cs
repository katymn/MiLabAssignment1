using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class enableText : MonoBehaviour
{
    [SerializeField] GameObject text1;
    [SerializeField] TMP_Text text2;

    public void enablingText()
    {
        text1.SetActive(true);
    }

    public void disablingText()
    {
        text1.SetActive(false);
    }

    public void activateBarryText ()
    {
        StartCoroutine(setBarryText());
    }

    IEnumerator setBarryText()
    {
        yield return new WaitForSeconds(3);
        text2.fontSize = 2;
        text2.SetText("these chickens gon' grow up nice and strong");
        yield return new WaitForSeconds(10);
        text2.SetText("you wanna eat these cute munchkins? are you crazy??");
        yield return new WaitForSeconds(10);
        text2.SetText("Barry");
        text2.fontSize = 4;
    }

}
