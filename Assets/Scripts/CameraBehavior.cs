using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    [SerializeField] float offsetX, offsetY, offsetZ;

    Transform player;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x + offsetX, player.position.y + offsetY, player.position.z + offsetZ); 
    }
}
