using System;
using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction.Samples;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class audioToggles : MonoBehaviour
{
    [SerializeField] AudioSource whistling;
    [SerializeField] AudioSource disco;
    [SerializeField] AudioSource edm;
    [SerializeField] TMP_Text volumeText;
    [SerializeField] Slider volumeSlider;
 

    bool firstToggle = true;
    bool toggle = false;

    //Power button
    public void larryPower()
    {
        //if off, turn on
        if (toggle == false)
        {
            whistling.Stop();
            toggle = true;
            changeTune();
        }
        //if on, turn off
        else if (toggle)
        {
            edm.Stop();
            disco.Stop();
            whistling.Play();
            toggle = false;
 
        }
        
    }

    //Change Tune
    public void changeTune()
    {
        //if interval 1, play disco
        if (firstToggle && toggle)
        {
            whistling.Stop();
            disco.Play();
            edm.Stop();
            firstToggle = false;
        }
        //if interval 2, play edm
        else if (firstToggle == false && toggle)
        {
            disco.Stop();
            edm.Play();
            firstToggle = true;
        }
    }

    public void pauseTune()
    {
        if (firstToggle && toggle)
        {
            disco.UnPause();
            edm.Pause();
            firstToggle = false;
        }
        else if (firstToggle == false && toggle)
        {
            disco.Pause();
            edm.UnPause();
            firstToggle = true;
        }
    }

    public void changeVolume()
    {
        edm.volume = volumeSlider.value;
        disco.volume = volumeSlider.value;
        volumeText.SetText("Volume: " + volumeSlider.value);
    }

    public void noActionActivateRadio()
    {
        toggle = true;
        larryPower();
    }
}
