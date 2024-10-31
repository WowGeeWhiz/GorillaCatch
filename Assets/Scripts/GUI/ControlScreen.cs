using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScreen : MonoBehaviour
{
    [SerializeField] GameObject controlsScreen;
    [Header("Controls Gameobjects")]
    [SerializeField] GameObject joystick;
    [SerializeField] GameObject dPad;

    public void SwitchControlScreen()
    {
        controlsScreen.SetActive(!controlsScreen.activeSelf);
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
