using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{

	void OnTriggerEnter2D(Collider2D collision)
	{
		// Tambah nilai properti score pada skrip Score
		if (collision.gameObject.tag == "Player")
        {
			Score.score++;
		}
	}
}