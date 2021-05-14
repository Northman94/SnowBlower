using UnityEngine;

public class TruckMovementManagerScript : MonoBehaviour
{
    [SerializeField]
    private float truckSpeed;

    private Touch touch;
    private Quaternion rotationY;
    private float rotationSpeed = 0.05f;



    // Used for Physics
    private void FixedUpdate()
    {
       transform.Translate(Vector3.forward * truckSpeed * Time.deltaTime, Space.Self);
    }


    private void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            
            rotationY = Quaternion.Euler(0f, touch.deltaPosition.x * rotationSpeed, 0f);

            transform.rotation = rotationY * transform.rotation;
        }
    }
}
