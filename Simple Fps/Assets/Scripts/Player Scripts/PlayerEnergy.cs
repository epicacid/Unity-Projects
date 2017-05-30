using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnergy : MonoBehaviour {

	[SerializeField]private int _energy = 50;

	public int Energy{
		get{ return _energy;}
		set{ _energy = value; }
	}

	void Update(){
		if (_energy > 50) {
			_energy = 50;
		}


	}

}
