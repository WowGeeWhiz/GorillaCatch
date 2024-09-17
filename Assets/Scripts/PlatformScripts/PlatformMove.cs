using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public float HorizontalSpeed = -5.0f;
    public float VerticalSpeed = 0.0f;
    Rigidbody rb;
    Vector3 direction;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector3(HorizontalSpeed, 0, VerticalSpeed);
        transform.Translate(direction * Time.deltaTime);
    }
}
