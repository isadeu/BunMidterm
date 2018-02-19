using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour {

	public GameObject bun;
	public float rotSpeed = 230.0f;
	public float forSpeed = 100f;
	public float jumpspeed = 8f;
	public bool isitgoing = false;
	public GameObject player;
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		var x = Input.GetAxis ("Horizontal") * Time.deltaTime * rotSpeed; //150  rotation
		var z = Input.GetAxis("Vertical") * Time.deltaTime * forSpeed; //3

		transform.Rotate(0, x, 0);
		transform.Translate(0, 0, z);

		if (Input.GetKeyDown (KeyCode.Space)) {
			Debug.Log ("spacing");
			GetComponent<Rigidbody> ().velocity = Vector3.up * jumpspeed;
			Physics.gravity = new Vector3 (0,-10,0);

			//GameObject.rigidbody. AddForce(Vector3.up * jumphight)

			//transform.Translate (Time.deltaTime * 30f);
		}


	}
}