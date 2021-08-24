using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class SideMovement : MonoBehaviour
{
	
	//Speed Boosting helped with this video https://www.youtube.com/watch?v=fDXtMlL2ahU

	private CharacterController controller;
	public float xSpeed = 10f;
	public float ySpeed = 5f;

	private Vector3 location;

	public float boostTimer;
	public bool boosting;

	public void changeXSpeed()
	{
		xSpeed = 20f;
	}
	
	

	void Start ()
	{
	controller = GetComponent<CharacterController>();

	boostTimer = 0;
	boosting = false;

	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "SpeedBoost")
		{
			boosting = true;
			xSpeed = 20f;
			Destroy(other.gameObject);
		}
	}


	// Update is called once per frame
	void Update ()
	{
		location.x = xSpeed * Input.GetAxis("Horizontal");
		location.y -= ySpeed * Input.GetAxis("Vertical");

		if (Input.GetAxis("Horizontal")> 0)
		{
			Vector3 newScale = new Vector3(1, 1, 1);
			transform.localScale = newScale;
		}
		else if (Input.GetAxis("Horizontal")< 0)
		{
			Vector3 newScale = new  Vector3(1, 1, 1 );
			transform.localScale = newScale;
		}
// got this from unity forms because my trials did not work https://docs.unity3d.com/ScriptReference/CharacterController.Move.html
		Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0,Input.GetAxis("Vertical"));
		controller.Move(move * Time.deltaTime * ySpeed);
		if (move != Vector3.zero)
		{
			gameObject.transform.forward = move;
		}

		if (Input.GetKeyDown(KeyCode.LeftShift))
		{
			xSpeed = 20f;
			ySpeed = 10f;
		}

		if (Input.GetKeyUp(KeyCode.LeftShift))
		{
			xSpeed = 10f;
			ySpeed = 5f;
		}

		if (controller.isGrounded)
		{
			location.y = 0;
			location.x = 0;
		}

		if (boosting)
		{
			boostTimer += Time.deltaTime;

			if (boostTimer >= 3)
			{
				xSpeed = 10;
				boostTimer = 0;
				boosting = false;
			}
		}
		

		controller.Move(location * Time.deltaTime);

	}
	
}

