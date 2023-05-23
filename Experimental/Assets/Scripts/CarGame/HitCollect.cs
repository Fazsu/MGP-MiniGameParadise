using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCollect : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            // Do something?
        }
        Destroy(gameObject);
    }
}
