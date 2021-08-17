using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUIManger : MonoBehaviour
{

	public bool gameEnded;

	public GameObject gameEndedUI;

	public void GameOver()
	{
		gameEndedUI.SetActive(true);
	}
	// Use this for initialization

	
	// Update is called once per frame
	public void DeathScreen()
	{
		if (gameEnded)
		{
			gameEnded = true;
			Debug.Log("Game Over");
		}

		
	}
	}
