using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsScreen : MonoBehaviour
{
    [SerializeField] GameObject controlsScreen;
    [Header("Controls")]
    [SerializeField] GameObject joystick;
    [SerializeField] GameObject dPad;
    
    public void SwitchControlScreen()
    {
        controlsScreen.SetActive(!controlsScreen.activeSelf);
        if(controlsScreen.activeSelf == true)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    public void ToggleJoystick()
    {
        dPad.SetActive(false);
        joystick.SetActive(true);
    }
    public void ToggleDPad()
    {
        joystick.SetActive(false);
        dPad.SetActive(true);
    }
}
