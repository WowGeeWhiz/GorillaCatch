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
        SceneManager.LoadScene(1);
    }

    public void AR()
    {
        audioData.Play();
        SceneManager.LoadScene(2);
    }

    public void LoadScene(string scene)
    {
        audioData.Play();
        SceneManager.LoadScene(scene);
    }
}
