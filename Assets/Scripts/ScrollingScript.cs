using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingScript : MonoBehaviour
{

    public float width = 20.48f;
    public float speedX = -2;

    void Update()
    {
        transform.Translate(speedX * Time.deltaTime, 0, 0);
        if (transform.position.x <= -1 * width)
        {
            transform.Translate(1 * width, 0, 0);
        }
    }
}