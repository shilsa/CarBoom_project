using System.Collections;
using UnityEngine;

public class SpeedMax : MonoBehaviour
{

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Car")
        {
            SpeedUp.SpdUp = 2f;
            Destroy(gameObject);
        }
    }
}
