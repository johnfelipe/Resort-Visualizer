using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ImageChanger : MonoBehaviour {

    private Manager manager;

    private ColorBlock colors;

    // Use this for initialization
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();
        if (manager == null) print("The Manager object is missing or broken!");
        else
        {
            try
            {
                GetComponent<Image>().color = manager.primaryColor;
            }
            catch (Exception e)
            {
                //print(e);
            }
        }
    }
}
