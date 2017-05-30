using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotation : MonoBehaviour {

	private float mouseInput;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		mouseInput = Input.GetAxis ("Mouse X"); //X axis mouse as input
		Vector3 lookhere = new Vector3 (0, mouseInput, 0); // New vector that gets the value of Mouse X on its y axis.
		transform.Rotate(lookhere); //Rotate the player on its Y axis using the mouse input.
	}
}
