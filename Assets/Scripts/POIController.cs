using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class controls the points of interest. It is attached to every POI object.
/// Here is where we store the new cameras position and rotation info.
/// </summary>
public class POIController : MonoBehaviour {

    /// <summary>
    /// These values are to be set via the inspector.
    /// Desired camera position and rotation:
    /// </summary>
    [Range(-179.0f, 179.0f)]
    public float desiredYaw;
    [Range(1.0f, 75.0f)]
    public float desiredPitch;
    [Range(5.0f, 25.0f)]
    public float desiredZoom;

    /// <summary>
    /// These are private references to the camera system and the camera movement script.
    /// </summary>
    private GameObject cameraSystem = null;
    private CameraMovement cm;

    /// <summary>
    /// In this start funciton we search for the gameobject with a Camera System tag.
    /// If we can't find it we will print out a message to the console.
    /// If it's found we will grab the CameraMovement script component from it.
    /// </summary>
    void Start()
    {
        cameraSystem = GameObject.FindGameObjectWithTag("Camera System");
        if (cameraSystem == null) print("Camera system is missing or broken");
        else cm = cameraSystem.GetComponent<CameraMovement>();
    }

    /// <summary>
    /// In this OnValidate function, if the cameraSystem is not null, we will call the MoveCamera function and pass in the gameobject that this script is attached to.
    /// </summary>
    void OnValidate()
    {
        if(cameraSystem != null) cm.MoveCamera(gameObject);
    }

    /// <summary>
    /// In this UpdatePOI funciton we will call the MoveCamera function and pass in the gameobject that this script is attached to.
    /// This funciton is called via HUD buttons.
    /// </summary>
    public void UpdatePOI()
    {
        if (cameraSystem != null) cm.MoveCamera(gameObject);
    }
}
