using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsScreen : MonoBehaviour
{
    public GameObject settingsPanel;
    public bool inSettings = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        settingsPanel.SetActive(inSettings);
    }

    public void SetSettings(bool val)
    {
        inSettings = val;
    }
}
