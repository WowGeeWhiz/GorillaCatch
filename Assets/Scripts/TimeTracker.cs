using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeTracker : MonoBehaviour
{

    internal float startTime;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.fixedTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool NewBestTime()
    {
        if (!PlayerPrefs.HasKey(SceneManager.GetActiveScene().name + "time") 
            || (PlayerPrefs.GetFloat(SceneManager.GetActiveScene().name + "time") > Time.fixedTime - startTime))
            {
            PlayerPrefs.SetFloat(SceneManager.GetActiveScene().name + "time", Time.fixedTime - startTime);
            return true;
        }
        return false;

    }



}
