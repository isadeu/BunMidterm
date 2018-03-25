using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {

	public float rotspeed = 30;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		//transform.Rotate(Vector3.left * Time.deltaTime * 10);
		transform.Rotate(Vector3.up * ( Time.deltaTime * rotspeed), Space.Self);
//		GetComponent<Transform>().localRotation = new Vector3(0f,GetComponent<Transform>().localRotation.y+1f,0f);

	}
}
