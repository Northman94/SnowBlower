using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckMovementManagerScript : MonoBehaviour
{
    [SerializeField]
    private float truckSpeed;


    private Vector3 touchPosition;
    private Rigidbody rb;
    private Vector3 direction;
    private float moseSpeed;


    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }

    // Used for Physics
    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * truckSpeed * Time.deltaTime, Space.Self);
    }



    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            touchPosition.y = 0;

            direction = (touchPosition - transform.position);

            rb.velocity = new Vector3(direction.x, 0, direction.z) * moseSpeed;


            if (touch.phase == TouchPhase.Ended)
            {
                rb.velocity = Vector3.zero;
            }
        }
    }
}
