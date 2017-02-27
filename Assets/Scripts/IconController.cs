using UnityEngine;
using System.Collections;

/// <summary>
/// The IconController script rotates the Marker objects to always face the camera.
/// </summary>
public class IconController : MonoBehaviour
{

    /// <summary>
    /// This is where we get our public gameobject references for our targetObject (Camera System).
    /// </summary>
    public GameObject targetObject;

    /// <summary>
    /// This is our speed for how fast the icons should lerp to the cameras new angle
    /// </summary>
    public float speed;

    /// <summary>
    /// These are our private variables for the target point and rotation
    /// </summary>
    Vector3 targetPoint;
    Quaternion targetRotation;

    /// <summary>
    /// In this Update method we set our target point to a new Vector3 based on our target objects x, y, and z position minus our icons transform position
    /// then we set our target rotation to the targetPoint and our icons Vector3.Up. Finally we rotate our icon based on a Slerp between the current rotation
    /// and the targetRotation based on deltaTime and our speed float.
    /// </summary>
    void Update()
    {
        targetPoint = new Vector3(targetObject.transform.position.x, targetObject.transform.position.y, targetObject.transform.position.z) - transform.position;
        targetRotation = Quaternion.LookRotation(targetPoint, Vector3.up);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * speed);
    }
}
