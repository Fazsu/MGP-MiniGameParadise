using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        string objectTag = other.gameObject.tag;
        switch (objectTag)
        {
            case "Fuel":
                Debug.Log("Fuel Collected");
                break;
            case "Friendly":
                Debug.Log("This thing seems friendly... for now...");
                break;
            case "Goal":
                Debug.Log("Goal Reached! Nice!");
                break;
            default: 
                Debug.Log("Boom. You blew up. Sorry I guess.");
                break;
        }
    }
}
