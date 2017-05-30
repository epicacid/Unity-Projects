using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	[SerializeField] private Transform _pivotPoint;
	private Transform _transform;
	Vector3 offSet;




	// Use this for initialization
	void Start () {
		_transform = GetComponent<Transform> ();
		offSet = _transform.position - _pivotPoint.position;
	}
	
	// Update is called once per frame
	void Update () {
		
		_transform.position = _pivotPoint.position + offSet;


	}
}
