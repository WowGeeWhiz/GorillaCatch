using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class PlatformMove : MonoBehaviour
{
    [SerializeField] Transform targetPos;
    [SerializeField] float increment;
    [SerializeField] float waitTime;
    Vector3 startPos;
    float interpolate = 0;
    private void Awake()
    {
        startPos = transform.position;
    }

    private void FixedUpdate()
    {
        StartCoroutine(LerpTo());
    }
    IEnumerator LerpTo()
    {
        yield return new WaitForSeconds(waitTime);
        interpolate += increment;
        transform.position = Vector3.Lerp(startPos, targetPos.position, interpolate);
        //Debug.Log("Interpol: "+ interpolate +" | Increment: " + increment + " | Pos: " + transform.position);
        if (interpolate >= 1 || interpolate <= 0)
        {
            increment *= -1;
        }
    }
}
