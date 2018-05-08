using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {


	public static void endGame(){
		SceneManager.LoadScene (2);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
