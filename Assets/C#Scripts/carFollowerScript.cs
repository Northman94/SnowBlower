using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carFollowerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject targetToFollow;

    private Transform destinationRotateTowards; //Target to rotate towards

    [SerializeField]
    float movementSpeed = 9f;
    [SerializeField]
    float rotationSpeed = 6f;


    void Start()
    {
        destinationRotateTowards = targetToFollow.transform;
    }

    
    void FixedUpdate()
    {
        
        
        /*
        // Car follower Movement
        if (transform.position != targetToFollow.transform.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetToFollow.transform.position, movementSpeed * Time.deltaTime);
        }
        */

        // Car follower Rotation
        // Determine which direction to rotate towards
        Vector3 targetDirection = destinationRotateTowards.position - transform.position;

        // Rotate the forward vector towards the target direction by one step
        //Vector3 newDirection = Vector3.RotateTowards(transform.right, targetDirection, rotationSpeed * Time.deltaTime, 0.0f);


        // Calculate a rotation a step closer to the target and applies rotation to this object
        transform.rotation = Quaternion.LookRotation(targetDirection);
        
    }
}
