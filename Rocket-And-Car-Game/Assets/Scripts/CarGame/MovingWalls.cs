using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWalls : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float hoverSpeed = 2f;
    [SerializeField] float altitude = 5;
    float randomVariable;
    void Start()
    {
        randomVariable = Random.Range(0f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        float zValue = Mathf.Sin(Time.time * hoverSpeed + randomVariable) / altitude;
        Vector3 movementVector = new Vector3(0, 0, zValue);
        transform.Translate(movementVector);
    }
}
