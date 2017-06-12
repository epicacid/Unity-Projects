using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpFood : MonoBehaviour {

	PlayerHealth _health;
	private bool safeRemove;
	private bool showText;
	Inventory inventory;

	void Start(){
		_health = GetComponent<PlayerHealth> ();
		safeRemove = false;
		showText = false;
		inventory = gameObject.GetComponent<Inventory>();

	}


	void OnTriggerStay(Collider other){
		showText = true;
		if (Input.GetKeyUp (KeyCode.E)) {
			
			inventory.AddItem (other.gameObject);

			_health.Health += 10;
			safeRemove = true;

			if (safeRemove) {
				showText = false;
				Destroy (other.gameObject);
			}
		}
	}

	void OnTriggerExit(Collider Other){
		showText = false;

	}

		
	void OnGUI(){
		if (showText) {
			GUI.Box(new Rect(Screen.width/ 2.66f, Screen.height/ 3.48f, Screen.width/ 3.78f, Screen.height/ 16.1f), "Press 'E' to pick up");
			}
		}
	}






