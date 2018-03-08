using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour {



	public Button restartbtn;
	// Use this for initialization
	void Start () {

		Button btn = restartbtn.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void TaskOnClick()
	{
		SceneManager.LoadScene ("hackyard");
	
	}
}
