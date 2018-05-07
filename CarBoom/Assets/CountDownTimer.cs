using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour {

	private float secondsLeft = 10f;
	public static bool timeout = false;

	private void OnGUI(){
		if( secondsLeft > 0)
			GUILayout.Label("Timeplay remaining: " + (int)secondsLeft     );
		else{
			GUILayout.Label("Time Out!");
			timeout = true;
			SceneManager.LoadScene (2);
		}

	}

	
	// Update is called once per frame
	void Update () {
		secondsLeft -= Time.deltaTime;
	}
}
