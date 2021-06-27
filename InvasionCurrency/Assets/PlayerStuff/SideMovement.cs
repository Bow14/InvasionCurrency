using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class SideMovement : MonoBehaviour
{

	private CharacterController controller;
	public float xSpeed = 10f;
	public float ySpeed = 5f;

	private Vector3 location;
	

	void Start ()
	{
	controller = GetComponent<CharacterController>();

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
			Vector3 newScale = new  Vector3(-1, 1, 1 );
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

		controller.Move(location * Time.deltaTime);

	}
	
}

