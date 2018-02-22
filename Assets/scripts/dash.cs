using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dash : MonoBehaviour {

	public Vector3 moveDirection;
	public GameObject bun;
	public float maxDashTime = 6f;
	public float dashSpeed = 1f;
	public float dashStoppingSpeed = 0.1f;
	private float currentDashTime = 10;
	public bool dashing = false;


	public Vector3 currentPosition;
	public Vector3 target;
	public float dashDistance = 4f;

	void Start()
	{
		currentPosition = bun.transform.position;
	}
	/*
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Z))
		{
			currentDashTime = 0;
		}
		if (currentDashTime < maxDashTime)
		{
			moveDirection = new Vector3 (dashSpeed, dashSpeed,dashSpeed);
			currentDashTime += dashStoppingSpeed;
		}
		else
		{
			moveDirection = Vector3.zero;
		}

		transform.position = moveDirection; 

	}*/

	void Update(){
		if (dashing == true) {
			bun.transform.position = Vector3.Lerp (currentPosition, target, dashSpeed * Time.deltaTime);

			if (Vector3.Distance (transform.position, target) < 0.1f) {
				dashing = false;
			}
		} else {
			if (Input.GetKeyUp (KeyCode.Z)) {
				dashing = true;
				target = transform.position * dashDistance;
			}

			// Regular movement code
		}
	}

}
