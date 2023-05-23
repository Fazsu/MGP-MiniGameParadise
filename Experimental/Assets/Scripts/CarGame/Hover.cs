using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour
{
    [SerializeField] float hoverSpeed = 2f;
    [SerializeField] float altitude = 0.005f;
    float randomVariable;
    void Start()
    {
        randomVariable = Random.Range(0, 2);
        
    }

    // Update is called once per frame
    void Update()
    {
        float yValue = Mathf.Sin(Time.time * hoverSpeed + randomVariable)*altitude;
        Vector3 movementVector = new Vector3(0, yValue, 0);
        transform.Translate(movementVector);
    }
}
