using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManScript : MonoBehaviour {
    public static AudioClip dead, kill, powerup, car;
    static AudioSource auSrc;

	// Use this for initialization
	void Start () {
        dead = Resources.Load<AudioClip>("imded");
        kill = Resources.Load<AudioClip>("enemyded");
        powerup = Resources.Load<AudioClip>("powup");
        car = Resources.Load<AudioClip>("drive");
        auSrc = GetComponent<AudioSource>();
        
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case ("imded"):
                auSrc.PlayOneShot(dead);
                break;
            case ("enemyded"):
                auSrc.PlayOneShot(kill);
                break;
            case ("powup"):
                auSrc.PlayOneShot(powerup);
                break;
            case ("drive"):
                auSrc.PlayOneShot(car);
                break;



        }
    }
}
