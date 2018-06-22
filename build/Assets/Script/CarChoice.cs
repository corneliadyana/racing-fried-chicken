using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour {

    public GameObject Hisana;
    public GameObject Dbesto;
    public GameObject KFC;
    public GameObject Rocky;
    public int CarImport;

    void Start()
    {
        CarImport = GlobalCar.CarType;
        if (CarImport == 1)
        {
            Hisana.SetActive(true);
        }

        if (CarImport == 2)
        {
            Dbesto.SetActive(true);
        }
        if (CarImport == 3)
        {
            KFC.SetActive(true);
        }

        if (CarImport == 4)
        {
            Rocky.SetActive(true);
        }
    }
}
