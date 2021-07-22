using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
	
	// Found this help on a form so im taking ideas on how to accomplish idea from it. https://stackoverflow.com/questions/37519034/falling-blocks-on-player-touch-unity-c
	//
	GameObject player;
	 bool playerEnter = false;
	 private bool playerLeft = false;

	private void Awake()
	{
		player = GameObject.Find("Player");
	}

public void Update()
	{
		if (player.transform.position.x == transform.position.x && player.transform.position.z == transform.position.z) //pretty much finding the player and entering the same cords
		{
			playerEnter = true; // saying if it enters the players position than destroy
			
		}

		if ((player.transform.position.x != transform.position.x || player.transform.position.z != transform.position.z) && playerEnter == true && playerLeft == false)
		{
			playerLeft = true;
			gameObject.AddComponent<Rigidbody>();
			Destroy(gameObject, 1.0f);
			//remember to look what != mean and || and &&
		}
	}
}
