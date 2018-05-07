using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class boomboomboom : MonoBehaviour {
    public AudioClip[] clips;
    public AudioMixerGroup output;
    public float minp = 0.95f;
    public float maxp = 1f;

    // Update is called once per frame
    void Update () {
        if(Input.GetKeyDown("space"))
        {
            playsound();

        }

    }
    void playsound()
    {
        int randomboom = Random.Range(0, clips.Length);
        AudioSource aud = gameObject.AddComponent< AudioSource > ();
        aud.clip = clips[randomboom];
        aud.outputAudioMixerGroup = output;
        aud.pitch = Random.Range(minp, maxp);
        aud.Play();
        Destroy(aud, clips[randomboom].length);
    }
}
