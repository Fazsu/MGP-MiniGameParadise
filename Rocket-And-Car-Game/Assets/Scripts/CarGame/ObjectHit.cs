using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private Color originalColor;
    string OriginalTag;
    [SerializeField] Color flashColor;
    void Start()
    {
        originalColor = GetComponent<Renderer>().material.color;
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Hit a wall!");
            StartCoroutine("wallHit");
        }
    }

    public IEnumerator wallHit ()
    {
        gameObject.tag = "Hit";
        GetComponent<Renderer>().material.color = flashColor;
        yield return new WaitForSeconds(0.2f);
        GetComponent<Renderer>().material.color = originalColor;
        gameObject.tag = "Wall";
        StopCoroutine("wallHit");
    }
}
