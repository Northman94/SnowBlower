using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckMovementManagerScript : MonoBehaviour
{
    [SerializeField]
    private float truckSpeed;
    
    void Start()
    {
        
    }

    // Used for Physics
    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * truckSpeed * Time.deltaTime, Space.Self);
    }



    private void Update()
    {
        
    }
}
