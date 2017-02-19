using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// This class stores the buttons corresponding POI object.
/// </summary>
public class ButtonLink : MonoBehaviour {
    public GameObject pointOfInterest;
    public GameObject cameraSystem;

    public void UpdatePOI()
    {
        cameraSystem.GetComponent<CameraMovement>().MoveCamera(pointOfInterest);
    }
}
