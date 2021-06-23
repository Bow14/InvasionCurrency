using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class SideMovement : MonoBehaviour
{

	private CharacterController controller;
	private float xSpeed = 10f;
	private float ySpeed = 5f;

	private Vector3 axis;
	

	void Start ()
	{
	controller = GetComponent<CharacterController>();

	}
	
	// Update is called once per frame
	void Update ()
	{
		axis.x = xSpeed * Input.GetAxis("Horizontal");
		axis.y = ySpeed * Input.GetAxis("Vertical");

		if (Input.GetAxis("Horizontal")> 0)
		{
			Vector3 newScale = new Vector3(1, 1, 1);
			transform.localScale = newScale;
		}
	}
}
