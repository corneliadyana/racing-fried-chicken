using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCar : MonoBehaviour
{


    public static int CarType; 
    public GameObject TrackWindow;

    public void Hisana()
    {
        CarType = 1;
        TrackWindow.SetActive(true);
    }

    public void DBesto()
    {
        CarType = 2;
        TrackWindow.SetActive(true);
    }

    public void KFC()
    {
        CarType = 3;
        TrackWindow.SetActive(true);
    }

    public void Rocky()
    {
        CarType = 4;
        TrackWindow.SetActive(true);
    }

}
