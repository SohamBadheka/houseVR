using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseController : MonoBehaviour {

	SharedResources sharedObj;

	public GameObject[] houses;

	void Awake() {
		sharedObj = GameObject.Find ("SharedObject").GetComponent<SharedResources>();

		for (int i = 0; i < houses.Length; i++) {
			if (i == sharedObj.selected) {
				houses [i].SetActive (true);
			} else {
				houses [i].SetActive (false);
			}
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
