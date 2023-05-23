using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = 0f;
        float y = 1f;
        float z = 0f;
        Vector3 rotator = new Vector3(x, y, z);
        transform.Rotate(rotator*Time.deltaTime*rotationSpeed, Space.World);
    }
}
