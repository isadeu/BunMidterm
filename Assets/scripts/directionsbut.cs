using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class directionsbut : MonoBehaviour {

	public Button whatbutton;
	public Button startbutton;
	public GameObject info;
	public GameObject canvasobject;

	// Use this for initialization
	void Start () {

		Button btn = whatbutton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		Debug.Log("You have clicked the second button!");
		//SceneManager.LoadScene ("hackyard");
		canvasobject.GetComponent<Canvas> ().enabled = false;
		info.SetActive (true);


		//Canvas.SetActive(false);
	}
}
