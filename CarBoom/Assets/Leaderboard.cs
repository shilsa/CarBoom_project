using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using AssemblyCSharp;

public class Leaderboard : MonoBehaviour {

	// Use this for initialization
	public Text text;

	void Start () {
		List<Player> Player_List = Result.getPlayerList (); 
		foreach (Player player in Player_List) {
			text.text = player.name;

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
