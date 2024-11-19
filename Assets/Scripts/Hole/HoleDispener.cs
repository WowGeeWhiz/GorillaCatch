using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleDispener : MonoBehaviour
{
    public GameObject Hole;
    public float xSpeed = 0.1f;
    public float zSpeed = 0f;
    public float tempX = 0f;
    public float tempZ = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LaunchHole()
    {

        GameObject g = Instantiate(Hole, transform.position, transform.rotation);

        //Randomize range
        if (xSpeed == 0)
        {
            tempX = Random.Range(-0.1f, 0.1f);
            g.GetComponent<Rigidbody>().velocity = new Vector3(tempX, 0, zSpeed);
        }
            
        if (zSpeed == 0)
        {
            tempZ = Random.Range(-0.1f, 0.1f);
            g.GetComponent<Rigidbody>().velocity = new Vector3(xSpeed, 0, tempZ);
        }
      
        
        Destroy(g, 5);
    }
}
