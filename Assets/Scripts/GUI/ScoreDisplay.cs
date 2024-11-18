using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI bestDisplay;
    public TextMeshProUGUI currentDisplay;
    TimeTracker timeTracker;
    // Start is called before the first frame update
    void Start()
    {
        timeTracker = FindFirstObjectByType<TimeTracker>();
        if (!PlayerPrefs.HasKey(SceneManager.GetActiveScene().name + "time"))
        {
            bestDisplay.text = "No best time";
        }
        else bestDisplay.text = "Best time: " + PlayerPrefs.GetFloat(SceneManager.GetActiveScene().name + "time") + " seconds";
    }

    // Update is called once per frame
    void Update()
    {
        if (timeTracker != null)
        {
            currentDisplay.text = "Current time: " + (Time.fixedTime - timeTracker.startTime).ToString();
        }
    }
}
