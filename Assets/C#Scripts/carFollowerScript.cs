using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carFollowerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject targetToFollow;

    private Transform destinationRotateTowards; //Target to rotate towards

    [SerializeField]
    float movementSpeed; //6
    [SerializeField]
    float rotationSpeed; //6

    private Vector3 followDistance;


    void Start()
    {
        destinationRotateTowards = targetToFollow.transform;
    }

    
    void FixedUpdate()
    { 
        // Car follower Movement
        if (transform.position != targetToFollow.transform.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetToFollow.transform.position, movementSpeed * Time.deltaTime);
        }
        

        // Determine which direction to rotate towards:
        // Car follower Rotation: Vector3 = Target - Camera location
        Vector3 targetDirection = destinationRotateTowards.position - transform.position;
        Vector3 currentState = transform.position;

        
        /*
        //Quaternion toRotation = Quaternion.FromToRotation(transform.forward, targetDirection);
        transform.rotation = Quaternion.LookRotation(transform.forward, transform.up);

        //transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, rotationSpeed * Time.time);

        //.rotation = Quaternion.LookRotation(toRotation);
        */

        Debug.DrawRay(transform.position, targetDirection, Color.red);


        /*
        float step = rotationSpeed * Time.deltaTime;

        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, step, 0.0F);

        Debug.DrawRay(transform.position, newDirection, Color.red);
        transform.rotation = Quaternion.LookRotation(newDirection);
        */


        



    }
}
