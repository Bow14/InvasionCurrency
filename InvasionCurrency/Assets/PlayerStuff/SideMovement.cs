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

		if (Input.GetAxis("Vertical")> 0)
		{
			Vector3 upScale = new Vector3(1, 1, 1);
			transform.localScale = upScale;
		}
		else if (Input.GetAxis("Vertical")< 0)
		{
			Vector3 upScale = new Vector3(1,-1,1);
			transform.localScale = upScale;
		}

		controller.Move(location * Time.deltaTime);

	}
	
}

