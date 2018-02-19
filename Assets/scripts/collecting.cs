using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collecting : MonoBehaviour {
	public int count; 

	// Use this for initialization
	void Start () {
		count = 0; 
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}

	void OnTriggerEnter (Collider c) {
		if (c.gameObject.CompareTag ("Player")) {
			Debug.Log ("oy nice food");
			Destroy(gameObject, .3f);
		}
	
	
	}
}
