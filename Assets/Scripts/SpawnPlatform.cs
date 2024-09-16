using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{

    public Rigidbody platform;

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
        
        Rigidbody instantiatedProjectile = Instantiate(platform, transform.position, transform.rotation) as Rigidbody;



        Destroy(instantiatedProjectile.gameObject, 20);

        yield return new WaitForSeconds(spawnTime);
        StartCoroutine(CreatePlatform());
    }
}
