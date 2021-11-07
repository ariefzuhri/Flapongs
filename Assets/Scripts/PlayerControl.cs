using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{

    public float speedY = 10.0f;
    public float boundX = -7.0f;

    Rigidbody2D rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var vel = rigid.velocity;
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            vel.y = speedY;
        }
        rigid.velocity = vel;

        // Batasi posisi X maskimal -7
        var pos = transform.position;
        if (pos.x > boundX)
        {
            pos.x = boundX;
        }
        transform.position = pos;

        // Kalau bolanya di belakang player (solusi sementara)
        GameObject[] balls = GameObject.FindGameObjectsWithTag("Ball");
        foreach (GameObject ball in balls)
        {
            if (ball.transform.position.x < pos.x)
            {
                Score.score = 0;
            }
            break;
        }
    }
}