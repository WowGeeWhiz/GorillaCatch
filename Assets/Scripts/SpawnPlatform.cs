using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{

    public GameObject platform;

    public float spawnTime = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreatePlatform());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CreatePlatform()
    {
        
        GameObject newPlatform = Instantiate(platform, transform.position, transform.rotation);
        newPlatform.transform.parent = transform;
        
        Destroy(newPlatform, 20);

        yield return new WaitForSeconds(spawnTime);
        StartCoroutine(CreatePlatform());
    }
}
