using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPlatform : MonoBehaviour
{
    [SerializeField] GameObject background;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            collision.gameObject.GetComponent<PlayerMovement>().ToggleCanMove();
            Time.timeScale = 0;
            if (GetComponent<TimeTracker>().NewBestTime())
            {
                SceneManager.LoadScene("WinScene");
            }
            else SceneManager.LoadScene("LoseScene");
            background.SetActive(true);
        }
    }
}
