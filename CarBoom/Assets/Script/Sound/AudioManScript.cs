using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManScript : MonoBehaviour {
    public static AudioClip dead, kill, powerup, car, bom1, bom2, bom3;
    static AudioSource auSrc;

	// Use this for initialization
	void Start () {
        dead = Resources.Load<AudioClip>("imded");
        kill = Resources.Load<AudioClip>("enemyded");
        powerup = Resources.Load<AudioClip>("powup");
        bom1 = Resources.Load<AudioClip>("boom1");
        bom2 = Resources.Load<AudioClip>("boom2");
        bom3 = Resources.Load<AudioClip>("boom3");
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
            case ("boom1"):
                auSrc.PlayOneShot(bom1);
                break;
            case ("boom2"):
                auSrc.PlayOneShot(bom2);
                break;
            case ("boom3"):
                auSrc.PlayOneShot(bom3);
                break;



        }
    }
}
