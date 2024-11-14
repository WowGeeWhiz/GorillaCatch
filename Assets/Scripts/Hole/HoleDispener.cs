using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleDispener : MonoBehaviour
{
    public GameObject Hole;
    public float xSpeed = 0.1f;
    public float zSpeed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            LaunchHole();
        }
    }

    public void LaunchHole()
    {
        GameObject g = Instantiate(Hole, transform.position, transform.rotation);
        g.GetComponent<Rigidbody>().velocity = new Vector3(xSpeed, 0, zSpeed);
        Destroy(g, 5);
    }
}
