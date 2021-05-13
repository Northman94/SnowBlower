using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCameraScript : MonoBehaviour
{
    public Transform targetToFollow;
    public Vector3 cameraOffset;

    public float smoothFactor = 1f; //between 0 and 1


    private void Start()
    {
        cameraOffset = transform.position - targetToFollow.transform.position;
    }


    private void LateUpdate() // best for camera
    {
        Vector3 DesiredPosition = targetToFollow.transform.position + cameraOffset;

        transform.position = Vector3.Lerp(transform.position, DesiredPosition, smoothFactor * Time.deltaTime);
    }
}
