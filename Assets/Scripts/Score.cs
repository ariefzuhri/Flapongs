using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

	public static int score = 0;

	void Start()
	{
		score = 0;
	}

	void OnGUI()
	{
		GetComponent<UnityEngine.UI.Text>().text = score.ToString();
	}
}