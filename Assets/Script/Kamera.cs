using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    public int kameraNerede;

    private Camera cam;

    void Start()
    {
        cam = Camera.main;

        kameraNerede = -1;
    }

    void Update ()
    {
        if (kameraNerede == 0 && Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = new Vector3(47f, 0f, -5f);
            kameraNerede = 1;
        }

        if (kameraNerede == -1 && Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = new Vector3(0f, 0f, -5f);
            kameraNerede = 0;
        }

        if (kameraNerede == 0 && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(-47f, 0f, -5f);
            kameraNerede = -1;
        }

        if (kameraNerede == 1 && Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(0f, 0f, -5f);
            kameraNerede = 0;
        }
    }

    public void ileri_Buton ()
    {
        if (kameraNerede == 0)
        {
            transform.position = new Vector3(47f, 0f, -5f);
            kameraNerede = 1;
        }
        
        if (kameraNerede == -1)
        {
            transform.position = new Vector3(0f, 0f, -5f);
            kameraNerede = 0;
        }
    }

    public void geri_Buton ()
    {
        if (kameraNerede == 0)
        {
            transform.position = new Vector3(-47f, 0f, -5f);
            kameraNerede = -1;
        }
    
        if (kameraNerede == 1)
        {
            transform.position = new Vector3(0f, 0f, -5f);
            kameraNerede = 0;
        }
    }
}
