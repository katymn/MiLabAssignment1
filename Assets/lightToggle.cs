using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class lightToggle : MonoBehaviour
{
    bool toggle = true;
    [SerializeField] Light lightSource;
    [SerializeField] TMP_Text intensityText;
    [SerializeField] Slider intensitySlider;

    // Update is called once per frame
    public void powerButton()
    {
        if (toggle)
        {
            lightSource.enabled = false;
            toggle = false;
        }

        else if (toggle == false)
        {
            lightSource.enabled = true;
            toggle = true;
        }
    }


    public void intensityChange()
    {
        if (toggle)
        {
            lightSource.intensity = intensitySlider.value;
            intensityText.SetText("Intensity: " + intensitySlider.value);
        }
    }
}
