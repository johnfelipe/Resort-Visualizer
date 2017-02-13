using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// </summary>
public class CameraMovement : MonoBehaviour
{

    /// <summary>
    /// This is the starting location and the target location of our object
    /// </summary>
    public Transform startingLocation;
    private Vector3 targetLocation;

    /// <summary>
    /// This is the speed of our lerp
    /// </summary>
    public float lerpSpeed = 5;

    /// <summary>
    /// In this Start method we set our target position to our starting location position and our target location to the same place.
    /// </summary>
    void Start()
    {
        transform.position = startingLocation.position;
        targetLocation = startingLocation.position;
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
    public void MoveCamera(Vector3 targetPos)
    {
        targetLocation = targetPos;
        //print("Target locaiton recieved");
    }
}
