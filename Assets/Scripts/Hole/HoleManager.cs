using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using TMPro;

public class HoleManager : MonoBehaviour
{
    public GameObject[] Dispensers = new GameObject[4];

    private bool isShooting;
    public float intensity;
    private int randDispensorStart;

    public float score;
    public TMP_Text scoreText;

    public void Start()
    {
        isShooting = false;
        intensity = 1f;
    }

    public void Awake()
    {

        score = 0;
    }

    void FixedUpdate()
    {
        score += Time.deltaTime;
        scoreText.text = Mathf.FloorToInt(score).ToString();

        // Only allow a new routine if there is none running already
        if (isShooting) return;

        StartCoroutine(shootRoutine());

        
    }

    private IEnumerator shootRoutine()
    {
        // Just in case avoid concurrent routines
        if (isShooting) yield break;

        isShooting = true;

        randDispensorStart = Random.Range(0, 3);

        Dispensers[randDispensorStart].SendMessage("LaunchHole");
        intensity += 0.1f;

        //Run code here
        if (intensity >= 2)
        {
            Dispensers[Random.Range(0, 3)].SendMessage("LaunchHole");
            intensity += 0.1f;
        }
        if (intensity >= 4)
        {
            Dispensers[Random.Range(0, 3)].SendMessage("LaunchHole");
            intensity += 0.1f;
        }
        if (intensity >= 8)
        {
            Dispensers[Random.Range(0, 3)].SendMessage("LaunchHole");
            intensity += 0.1f;
        }
        if (intensity >= 16)
        {
            Dispensers[Random.Range(0, 3)].SendMessage("LaunchHole");

        }



        yield return new WaitForSeconds(5f/intensity);

        isShooting = false;
    }
}
