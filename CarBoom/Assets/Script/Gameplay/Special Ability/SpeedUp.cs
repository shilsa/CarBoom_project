using System.Collections;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public static float SpdUp = 0f;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Car")
        {
            SpdUp += 0.5f;
            Destroy(gameObject);
        }
    }
}
