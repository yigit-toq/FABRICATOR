using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tekerlek : MonoBehaviour
{
    public Objeler objeKod;
    public bant bantKod;

    private Vector3 yön;

    void Start ()
    {
        bantKod = FindObjectOfType<bant>();
    }

    void Update()
    {
        if (bantKod.skor >= 0 && bantKod.pause == false && bantKod.skor < 100 && bantKod.can > 0) {
            yön = transform.eulerAngles;
            yön.z = yön.z - 1.5f;
            transform.eulerAngles = yön; 
        }

        if (bantKod.skor >= 100 && bantKod.pause == false &&  bantKod.skor < 300 && bantKod.skor >= 0 && bantKod.can > 0)
        {
            yön = transform.eulerAngles;
            yön.z = yön.z - 2f;
            transform.eulerAngles = yön;
        }

        if(bantKod.skor >= 300 && bantKod.pause == false && bantKod.skor < 500 && bantKod.skor >= 0 && bantKod.can > 0)
        {
            yön = transform.eulerAngles;
            yön.z = yön.z - 2.5f;
            transform.eulerAngles = yön;
        }

        if (bantKod.skor >= 500 && bantKod.pause == false && bantKod.skor >= 0 && bantKod.can > 0)
        {
            yön = transform.eulerAngles;
            yön.z = yön.z - 3f;
            transform.eulerAngles = yön;
        }
    }
}
