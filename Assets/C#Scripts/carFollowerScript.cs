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

     
        //Debug.DrawRay(transform.position, targetDirection, Color.red);
    }
}
