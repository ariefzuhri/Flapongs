using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollColumn : MonoBehaviour
{

    public float width = 20.48f;
    public float speedX = -2;

    public float minRange = -1.0f;
    public float maxRange = 2.0f;

    void Start()
    {
        transform.position = new Vector2(transform.position.x, Random.Range(minRange, maxRange));
    }

    void Update()
    {
        transform.Translate(speedX * Time.deltaTime, 0, 0);
        if (transform.position.x <= -1 * width)
        {
            transform.Translate(2 * width, 0, 0);
            transform.position = new Vector2(transform.position.x, Random.Range(minRange, maxRange));
        }
    }
}