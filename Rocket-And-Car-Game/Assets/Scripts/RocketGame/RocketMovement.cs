using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float flySpeed = 0.2f;
    [SerializeField] float rotateSpeed = 0.2f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }
    
    void ProcessThrust()
    {
        bool bSpace = Input.GetKey(KeyCode.Space);
        
        if(bSpace)
        {
            Debug.Log("Pressed SPACEBAR - Thrusting");
            rb.AddRelativeForce(Vector3.up*flySpeed);
        }
    }

    void ProcessRotation()
    {
        bool bLeftArrow = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow);
        bool bRightArrow = Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow);
        
        if(bLeftArrow)
        {
            ApplyRotation(rotateSpeed);
        }
        else if(bRightArrow)
        {
            ApplyRotation(-rotateSpeed);
        }
    }

    private void ApplyRotation(float rotationThisFrame)
    {
        rb.freezeRotation = true; // Freeze Rotation inorder to manually rotate
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        rb.freezeRotation = false; // Release the freeze
    }
}
