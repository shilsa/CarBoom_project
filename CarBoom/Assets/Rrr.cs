using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rrr : MonoBehaviour
{
    public static AudioClip car;
    static AudioSource auSrc;

    // Use this for initialization
    void Start()
    {
        
        car = Resources.Load<AudioClip>("Rrr");
        auSrc = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {

    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
          
            case ("Rrr"):
                auSrc.PlayOneShot(car);
                break;




        }
    }
}
