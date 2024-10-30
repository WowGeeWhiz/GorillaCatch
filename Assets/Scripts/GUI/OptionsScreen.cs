using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsScreen : MonoBehaviour
{
    [SerializeField] GameObject mainScreen;
    [SerializeField] GameObject settingScreen;


    public void SwitchSettings()
    {
        mainScreen.SetActive(!mainScreen.activeSelf);
        settingScreen.SetActive(!settingScreen.activeSelf);
    }
}
