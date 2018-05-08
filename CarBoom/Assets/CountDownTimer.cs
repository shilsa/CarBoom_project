using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountDownTimer : MonoBehaviour {

	private float secondsLeft = 3f;

	private void OnGUI(){
		if( secondsLeft > 0)
			GUILayout.Label("Timeplay remaining: " + (int)secondsLeft     );
		else{
			GUILayout.Label("Time Out!");
			EndGame.endGame ();
		}

	}

	
	// Update is called once per frame
	void Update () {
		secondsLeft -= Time.deltaTime;
	}
}
