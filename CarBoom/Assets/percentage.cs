using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class percentage : MonoBehaviour {
    Text ptext;


	// Use this for initialization
	void Start () {
        ptext.GetComponent<Text>();
		
	}
	
	// Update is called once per frame
	public void textUpdate (float value) {
        ptext.text = Mathf.RoundToInt(value * 100) + "%";
		
	}
}
