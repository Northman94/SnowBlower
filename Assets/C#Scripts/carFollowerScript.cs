using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carFollowerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject targetToFollow;

    private Transform destinationRotateTowards; //Target to rotate towards


    void Start()
    {
        destinationRotateTowards = targetToFollow.transform;
    }

    
    void FixedUpdate()
    {
        // The step size is equal to speed times frame time.
        float singleStep = 4f * Time.deltaTime;


        if (transform.position != targetToFollow.transform.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetToFollow.transform.position, singleStep);
        }


        // Determine which direction to rotate towards
        Vector3 targetDirection = destinationRotateTowards.position - transform.position;

        // Rotate the forward vector towards the target direction by one step
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);


        // Calculate a rotation a step closer to the target and applies rotation to this object
        transform.rotation = Quaternion.LookRotation(newDirection);
    }
}
