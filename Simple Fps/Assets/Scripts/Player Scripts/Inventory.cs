using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

	public List<GameObject> inventory = new List<GameObject>();


	public void AddItem(GameObject go){
		inventory.Add(go);

	}
}
