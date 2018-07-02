﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControlActive : MonoBehaviour {

    // Use this for initialization
    public GameObject CarControl;
    public GameObject Dreamcar01;

    void Start()
    {
        CarControl.GetComponent<CarUserControl>().enabled = true;
        Dreamcar01.GetComponent<CarAIControl>().enabled = true;
    }
}
