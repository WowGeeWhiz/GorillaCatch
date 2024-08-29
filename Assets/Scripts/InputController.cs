using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputController : MonoBehaviour
{
    Touch touch;
    Vector2 touchStartPosition, touchEndPosition;
    bool movePlayer = true;
    public PlayerController player;
    float maxX, maxY;

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(Screen.width, Screen.height, true);
        maxX = Screen.width; 
        maxY = Screen.height;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
        }

        if (touch.phase == TouchPhase.Began)
        {
            touchStartPosition = touch.position;
        }
        else if (touch.phase == TouchPhase.Moved)
        {
            touchEndPosition = touch.position;
        }
        else if (touch.phase == TouchPhase.Ended)
        {
            touchStartPosition = touchEndPosition = Vector2.zero;
        }

        float x = (touchEndPosition.x - touchStartPosition.x) / maxX;
        float y = (touchEndPosition.y - touchStartPosition.y) / maxY;
        Debug.Log($"x={x}  y={y}");
        if (movePlayer)
        {
            if (x > 0) player.transform.position += new Vector3(player.xSpeed, 0, 0);
            else if (x < 0) player.transform.position += new Vector3(-player.xSpeed, 0, 0);
        }

    }
}
