using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class follo : MonoBehaviour
{

	public Transform Player;
	public int MoveSpeed = 4;
	public int MaxDist = 10;
	public int MinDist = 5;
	UnityEngine.AI.NavMeshAgent agent;



	void Start()
	{
		agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
	
	}

	void Update()
	{

		agent.destination = Player.position;
		transform.LookAt(Player);

		if (Vector3.Distance(transform.position, Player.position) >= MinDist)
		{

			transform.position += transform.forward * MoveSpeed * Time.deltaTime;



			if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
			{
				SceneManager.LoadScene ("GO");
				//Here Call any function U want Like Shoot at here or something
			}

		}
	}
}
