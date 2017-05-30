using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	[SerializeField] private float _health = 100.0f;

	public float Health {
		get{return _health; }
		set{_health = value;}
	}

	void Update(){
		if (_health > 100) {
			_health = 100;
		}

	}





}
