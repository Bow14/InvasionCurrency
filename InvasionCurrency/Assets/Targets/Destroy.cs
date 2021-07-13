using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
	private float delay = 3f;

	// Use this for initialization
	void Start () {
		Destroy(gameObject, delay);
	}
	
	// Update is called once per frame
	private void OnDestroy()
	{
		Destroy(gameObject);
	}
}
