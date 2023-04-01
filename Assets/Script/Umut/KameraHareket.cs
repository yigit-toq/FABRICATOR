using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraHareket : MonoBehaviour
{
    public float OzelX = 0;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            OzelX -= 0.5f * (Input.GetAxis("Fare X"));

        }
        else
        {
            OzelX += Input.GetAxis("Yatay") * Time.deltaTime * 20;
        }

        if (OzelX < 0)
        {
            OzelX = 0;
        }
        if (OzelX > 36)
        {
            OzelX = 36;
        }

        transform.position = new Vector3(OzelX, 0, -10);
    }
}
