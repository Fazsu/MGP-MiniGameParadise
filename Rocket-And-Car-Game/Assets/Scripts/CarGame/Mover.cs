using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // X, Y, Z values for movement speed
    [SerializeField] float moveSpeed = 10f;
    
    void Start()
    {
        
    }

    void Update()
    {
        if(Time.time > 1.3f){
            MovePlayer();
        }
    }

    void MovePlayer()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVeritcal = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(moveHorizontal, 0, moveVeritcal);

        Vector3 rotationDirection = new Vector3(-1*moveVeritcal, 0, moveHorizontal);
        if (rotationDirection != Vector3.zero){
            transform.rotation = Quaternion.LookRotation(rotationDirection);
            transform.Translate(movementDirection * moveSpeed * Time.deltaTime, Space.World);
        }
    }
}
