using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Koli : MonoBehaviour
{
    public BantTekerleri kod;
    void Start()
    {
        
    }
    void Update()
    {
        transform.position += new Vector3(kod.Hiz, 0, 0);
    }
}
