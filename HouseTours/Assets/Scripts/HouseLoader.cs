using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HouseLoader : MonoBehaviour {

	SharedResources sharedObj;

	void Awake() {
		sharedObj = GameObject.Find ("SharedObject").GetComponent<SharedResources>();
	}

	// Use this for initialization
	void Start () {
		print (sharedObj.selected);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SelectHouse(int hNumber) {
		sharedObj.selected = hNumber;
		SceneManager.LoadScene ("TheHouse");
	}
}
