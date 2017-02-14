using UnityEngine;
using System.Collections;

/// <summary>
/// This class takes the users input and controls the cameras interactions
/// The users can rotate the camera or move its position to a new target location
/// </summary>
public class CameraController : MonoBehaviour
{

    /// <summary>
    /// This is the public info for the cameras rotation
    /// </summary>
    public Transform camYaw;
    public Transform camPitch;
    public bool invertLookY = true;

    /// <summary>
    /// This is the public sensitivity info
    /// </summary>
    public float MouseSensitivityX = 4;
    public float MouseSensitivityY = 4;
    public float MouseSensitivityScroll = 2;

    /// <summary>
    /// This is our max and min zoom values
    /// </summary>
    public float maxZoom = 20;
    public float minZoom = 1;

    private float prevY;
    private float prevZ;

    /// <summary>
    /// This is the private info such as the moues starting position, the pitch, yaw, and scroll amounts
    /// </summary>
    float camPitchAmount;
    float yaw;
    float scroll;

    /// <summary>
    /// In this Start method we make our max and min zoom values negative
    /// </summary>
    void Start()
    {
        maxZoom *= -1;
        minZoom *= -1;
    }

    /// <summary>
    /// In this Update method all we need to do is call our MouseInput method
    /// </summary>
    void Update()
    {
        MouseInput();
    }

    /// <summary>
    /// In this MouseInput method we start by settinog our scroll float to the axis of our mouses scrollwheel
    /// Then we set the localposition to the localPosition.z + our scroll offset * our mouse scroll sensitivity
    /// We have to use a local position so we don't mess with the parent object
    /// 
    /// Next we check to see if we are outside our upper or lower bounds for our zoom
    /// 
    /// Then we get our left mouse click input, if the user has clicked it means they might be trying to rotate the camera
    /// we set our PrevY and PrevZ to the camPitches previous euler angels for Y and Z, we will use these to reset if the user tries to exceed the max pitch
    /// 
    /// Next we get our yaw input from our Mouse X and our pitch input from the Mouse Y values. If the mouse is inverted we invert it here.
    /// Then we clap the pitch amount.
    /// 
    /// To rotate we call our camYaw and camPitch objects and tell them to rotate. Then we make sure that the min and max pitch values are within our preset limits
    /// We also limiti the camPitches Z angle to 0, if it ever becomes somthing other than 0 we reset it back to 0, if we don't do this the camera will break and the
    /// user would be upside down. They wern't acutally upside down the camera just rolled enough to appear upsided down.
    /// </summary>
    void MouseInput()
    {
        scroll = Input.GetAxis("Mouse ScrollWheel");

        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z + scroll * MouseSensitivityScroll);

        if (transform.localPosition.z > minZoom)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, minZoom);
        }

        if (transform.localPosition.z < maxZoom)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, maxZoom);
        }

        if (Input.GetButton("Fire1"))
        {
            float prevY = camPitch.rotation.eulerAngles.y;
            float prevZ = camPitch.rotation.eulerAngles.z;

            yaw = Input.GetAxis("Mouse X");
            camPitchAmount = Input.GetAxis("Mouse Y") * MouseSensitivityY * (invertLookY ? -1 : 1);
            camPitchAmount = Mathf.Clamp(camPitchAmount, -10, 80);

            camYaw.Rotate(0, yaw * MouseSensitivityX, 0);
            camPitch.Rotate(camPitchAmount, 0, 0);
        }

        //This limits the pitch to a minimum preset angel
        if (camPitch.rotation.eulerAngles.x < 1 || camPitch.rotation.eulerAngles.x > 300)
        {
            camPitch.eulerAngles = new Vector3(1, camPitch.rotation.eulerAngles.y, camPitch.rotation.eulerAngles.z);
        }

        //This limits the pitch to a preset angle
        if (camPitch.rotation.eulerAngles.x > 75)
        {
            camPitch.eulerAngles = new Vector3(75, camPitch.rotation.eulerAngles.y, camPitch.rotation.eulerAngles.z);
        }

        //This will prevent the camera from breaking and going past the max angle pitch angle
        if (camPitch.rotation.eulerAngles.z != 0)
        {
            camPitch.eulerAngles = new Vector3(camPitch.rotation.eulerAngles.x, camPitch.rotation.eulerAngles.y, 0);
        }

        //print("Euler Angles: " + camPitch.eulerAngles);
    }
}
