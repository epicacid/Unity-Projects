using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	private Animator _anim;
	private float _horz;
	private float _vert;
	[SerializeField]private float movSpeed = 10.0f;
	private Transform _thisTransform;




	// Use this for initialization
	void Start () {
		_anim = GetComponent<Animator> ();
		_thisTransform = GetComponent<Transform> ();




	}
	
	// Update is called once per frame
	void FixedUpdate () {
		_horz = Input.GetAxis ("Horizontal");
		_vert = Input.GetAxis ("Vertical");

		_anim.SetFloat ("Walk", _vert);
		_anim.SetFloat ("Horizontal", _horz);

		_thisTransform.position += transform.forward * movSpeed * _vert * Time.deltaTime;
		_thisTransform.position += transform.right * movSpeed * _horz * Time.deltaTime;






}


}