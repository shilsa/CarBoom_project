using System.Collections;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Car")
        {
            if (Explosion.lenghtmax < 10f)
            {
                Explosion.lenghtmax += 1f;
            }
            Destroy(gameObject);
        }
    }
}
