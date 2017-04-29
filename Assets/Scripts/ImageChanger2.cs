using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ImageChanger2 : MonoBehaviour {

    private Manager manager;

    // Use this for initialization
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();
        if (manager == null) print("The Manager object is missing or broken!");
        else
        {
            try
            {
                GetComponent<Image>().color = manager.secondaryColor;
            }
            catch (Exception e)
            {
                //print(e);
            }
        }
    }
}
