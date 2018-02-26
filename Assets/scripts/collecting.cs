using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class collecting : MonoBehaviour { 
	//public Text countText;

	// Use this for initialization
	void Start () {
		/*count = 0; 
		countText.text = "snacks munched: " + count.ToString () + "/3";

*/		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}

	void OnTriggerEnter (Collider c) {
		if (c.gameObject.CompareTag ("Player")) {
			Destroy (gameObject);
			/*count = count +1; //count += 1; 
			countText.text = "snacks munched: " + count.ToString () + "/3";
*/
		}
	
	
	}
}
