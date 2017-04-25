using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharedResources : MonoBehaviour {

	public int selected = 1;

	void Awake() {
		DontDestroyOnLoad (gameObject);
	}

}
