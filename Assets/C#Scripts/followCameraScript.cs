using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCameraScript : MonoBehaviour
{
    public Transform targetToFollow;

    public float SmoothSpeed = 0.125f; //between 0 and 1

    [SerializeField]
    public Vector3 CameraOffset;


    private void LateUpdate() // best for camera
    {
        Vector3 DesiredPosition = targetToFollow.position + CameraOffset;

        Vector3 SmoothedPosition = Vector3.Lerp(transform.position, DesiredPosition, SmoothSpeed * Time.deltaTime);

        transform.position = SmoothedPosition;

        //transform.LookAt(TargetPlayer);
    }
}
