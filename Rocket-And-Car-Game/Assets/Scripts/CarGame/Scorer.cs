using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
    {
    int hits = 0;
    int collected = 0;
    [SerializeField] int Health = 5;
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Wall"){
            hits ++;
        }
        if (other.gameObject.tag == "Enemy"){
            Health--;
        }
        if (other.gameObject.tag == "Apple"){
            collected ++;
        }
        
        Debug.Log("Health Left: " + Health);
        Debug.Log("Bump count: " + hits);
        Debug.Log("Apples collected: " + collected);
    }
}
