using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using AssemblyCSharp;

public class Result : MonoBehaviour {


	public InputField name;
	public Text score;

	public static List<Player> Player_List = new List<Player>();

	public void Start(){
		score.text = "0";
	}	
		
	public static List<Player> getPlayerList(){
		return Player_List;
	}

	public void BacktoMenu(){
		SceneManager.LoadScene (0);
		Player player = new Player ();
		player.name = name.text;
		player.score = int.Parse (score.text);
		Player_List.Add (player);


	}
}
