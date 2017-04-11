using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaylightController : MonoBehaviour {

    private float sunIntensity;
    private float xRotation = -50;
    private bool isDay = true;

    private Manager manager;

    private Light sun;

    // Use this for initialization
    void Start () {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();
        if (manager == null) print("The Manager object is missing or broken!");
        else
        {
            sunIntensity = manager.daylightIntensity;
            sun = GetComponent<Light>();
            sun.intensity = sunIntensity;
        }
    }
	
	public void ToggleDaylight()
    {
        if (isDay)
        {
            transform.rotation = Quaternion.Euler(new Vector3(-50, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z));
            sun.intensity = 0;
            isDay = false;
            return;
        }else
        {
            transform.rotation = Quaternion.Euler(new Vector3(50, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z));
            sun.intensity = sunIntensity;
            isDay = true;
            return;
        }
    }
}
