using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {
	public float rotationspeed = 40;

	// Use this for initialization
	void Start () {
		Debug.Log("why isnt this printing");

		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up * ( Time.deltaTime * rotationspeed), Space.World);
		
	}
}
