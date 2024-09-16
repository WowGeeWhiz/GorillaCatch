using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(AudioSource))]
public class NextLevel : MonoBehaviour
{

    AudioSource audioData;

    void Awake()
    {
        audioData = GetComponent<AudioSource>();
    }


    // Start is called before the first frame update
    public void Next()
    {
        audioData.Play();
        //Application.LoadLevel(Application.loadedLevel + 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
