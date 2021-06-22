using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SideMovement : MonoBehaviour
{

	private CharacterController controller;
	private float leftSpeed = 10f;
	private float rightSpeed = 10f;
	private float upSpeed = 5f;
	private float downSpeed = 5f;
	

	void Start ()
	{
	controller = GetComponent<CharacterController>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
