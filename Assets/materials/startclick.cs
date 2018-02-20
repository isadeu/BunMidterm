using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startclick : MonoBehaviour {

	public Button startbutton;

	// Use this for initialization
	void Start () {
		
		Button btn = startbutton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		Debug.Log("You have clicked the button!");
		SceneManager.LoadScene ("hackyard");

	}
}
