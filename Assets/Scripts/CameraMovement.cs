using UnityEngine;
using System.Collections;

/// <summary>
/// The CameraMovement script moves the focus point for the Camera System object from one POI to another.
/// </summary>
public class CameraMovement : MonoBehaviour
{

    /// <summary>
    /// This is the starting location and the target location and camera settings for our Camera System.
    /// </summary>
    public GameObject startingLocation;

    /// <summary>
    /// This is the targetLocation that we want to Lerp to.
    /// </summary>
    private Vector3 targetLocation;

    /// <summary>
    /// This is the speed of our lerp.
    /// </summary>
    public float lerpSpeed = 5;

    /// <summary>
    /// In this Start funciton we check to see if our starting locaiton has a POIController script, if it does we will store the component
    /// in a temp variable. We will then set our Camera Systems position to our starting locations position. We will also set the value of
    /// our targetLocation to the starting position.
    /// 
    /// Once the focus point is set we will call the CameraController script that is attached to the Main Camera. We will call the MoveToPosition
    /// script while passing in the starting locations desired yaw, pitch, and zoom float values.
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
    /// In this MoveCamera function we check to see if our target is a POI object. If it is we will update the targetLocation to be the targets position. We will also
    /// tell our CameraController script to move to the new desired position.
    /// </summary>
    /// <param name="target">This POI GameObject will be the new focus point for the Camera System.</param>
    public void MoveCamera(GameObject target)
    {
        //Check to see if our starting position is a PoI object.
        if (target.GetComponent<POIController>() != null)
        {
            POIController temp = target.GetComponent<POIController>();

            targetLocation = target.transform.position;

            GetComponentInChildren<CameraController>().MoveToPosition(temp.desiredYaw, temp.desiredPitch, temp.desiredZoom);
        }
        else
        {
            print("The target object doesn't have the POIController script.");
        }
    }
}
