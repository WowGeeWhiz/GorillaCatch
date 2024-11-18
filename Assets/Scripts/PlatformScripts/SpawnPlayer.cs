using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    [SerializeField] GameObject playerPrefab;

    private void Awake()
    {
        Instantiate(playerPrefab, transform.position + (Vector3.up * .5f), Quaternion.identity);
    }
}
