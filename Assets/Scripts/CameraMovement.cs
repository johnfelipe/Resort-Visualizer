using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// </summary>
public class CameraMovement : MonoBehaviour
{

    /// <summary>
    /// This is the starting location and the target location of our object
    /// Along with the desired camera settings
    /// </summary>
    public GameObject startingLocation;
    private Vector3 targetLocation;

    /// <summary>
    /// This is the speed of our lerp
    /// </summary>
    public float lerpSpeed = 5;

    /// <summary>
    /// In this Start method we set our target position to our starting location position and our target location to the same place.
    /// We also grab the desired camera yaw, pitch, and zoom.
    /// </summary>
    void Start()
    {
        //Check to see if our starting position is a PoI object.
        if (startingLocation.GetComponent<POIController>() != null)
        {
            POIController temp = startingLocation.GetComponent<POIController>();

            transform.position = startingLocation.transform.position;
            targetLocation = startingLocation.transform.position;

            GetComponentInChildren<CameraController>().MoveToPosition(temp.desiredYaw, temp.desiredPitch, temp.desiredZoom);
        }
        else
        {
            print("The starting point doesn't have the POIController script.");
        }
    }

    /// <summary>
    /// In this Update method we check to see if this objects position is equal to our target locaiton, if it isn't we need to set this objects position to a lerp between
    /// the current position and the target location * deltaTime * lerpSpeed.
    /// </summary>
    void Update()
    {
        if (transform.position != targetLocation)
        {
            transform.position = Vector3.Lerp(transform.position, targetLocation, Time.deltaTime * lerpSpeed);
            //print("Moving to target location");
        }
    }

    /// <summary>
    /// In this public method we take a new targetPos and set it to be our target location
    /// </summary>
    /// <param name="targetPos">This value (Vector3) will become the new target location for our camera</param>
    public void MoveCamera(GameObject target)
    {
        //Check to see if our starting position is a PoI object.
        if (startingLocation.GetComponent<POIController>() != null)
        {
            POIController temp = target.GetComponent<POIController>();

            targetLocation = target.transform.position;

            GetComponentInChildren<CameraController>().MoveToPosition(temp.desiredYaw, temp.desiredPitch, temp.desiredZoom);
        }
        else
        {
            print("The starting point doesn't have the POIController script.");
        }
    }
}
