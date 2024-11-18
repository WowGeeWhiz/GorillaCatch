using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils.Datums;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deleteScoresButton : MonoBehaviour
{
    public string[] scoreKeyNames;
    public void DeleteScores()
    {
        for (int i = 0; i < scoreKeyNames.Length; i++)
        {
            if (PlayerPrefs.HasKey(scoreKeyNames[i])){
                PlayerPrefs.DeleteKey(scoreKeyNames[i]);
            }
        }
    }
}
