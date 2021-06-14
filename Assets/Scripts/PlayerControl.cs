using System.Collections;
using System;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 1f;

    private void Update()
    {
        Vector3 DontBeganVector = new Vector3(50f, 50f, 0);

        foreach (Touch touch in Input.touches) {

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if(transform.position != DontBeganVector)
                        TouchPlayerMove(touch);
                    break;
                case TouchPhase.Ended:
                    transform.position = new Vector3(100f, 100f, 0f);
                    break;
            }
            
        }
    }

    void TouchPlayerMove(Touch touch)
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 2f));
    }
}
