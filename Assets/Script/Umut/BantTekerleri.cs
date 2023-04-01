using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BantTekerleri : MonoBehaviour
{
    public float Hiz = 0.5f;
    private Vector3 Yon;
    void Start()
    {
        Yon = transform.eulerAngles;
        Yon.z = Random.Range(0, 180);
    }
    void Update()
    {
        Yon.z = Yon.z - Hiz;
        transform.eulerAngles = Yon;
    }
}
