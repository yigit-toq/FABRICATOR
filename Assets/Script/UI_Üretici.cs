using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Üretici : MonoBehaviour
{
    public GameObject obje1;
    public GameObject obje2;
    public GameObject obje3;

    public GameObject secilenObje;

    public int hangiObje;

    public float üreticiSüre;

    void Start()
    {
        üreticiSüre = 100;
        hangiObje = 1;
    }

    void Update()
    {
        if (üreticiSüre >= 0)
        {
            üreticiSüre++;
            if (üreticiSüre >= 150)
            {
                transform.position = new Vector3(Random.Range(-21, 21), 15f);
                hangiObje = Random.Range(1, 4);
                Instantiate (secilenObje,transform.position,Quaternion.identity);
            }
        }

        if (üreticiSüre > 150)
        {
            üreticiSüre = 0;
        }

        if (hangiObje == 1)
        {
            secilenObje = obje1;
        }
        else if (hangiObje == 2)
        {
            secilenObje = obje2;
        }
        else if (hangiObje == 3)
        {
            secilenObje = obje3;
        }
    }
}
