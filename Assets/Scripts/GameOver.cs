using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

	void OnTriggerEnter2D(Collider2D collision)
	{

		string gotHitTag = transform.parent.gameObject.tag;
		string theHitTag = collision.gameObject.tag;

		if (gotHitTag == "Column" && theHitTag == "Player")
		{
			Score.score = 0;
		}
		else if (gotHitTag == "Wall" && theHitTag == "Ball") // Masih enggak mau
		{
			Score.score = 0;
			collision.gameObject.SendMessage("RestartGame", 0.5f, SendMessageOptions.RequireReceiver);
		}
	}
}