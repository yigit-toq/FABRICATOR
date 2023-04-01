using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Yok_Et : MonoBehaviour
{
    public bant Bant;
    public Envanter envanter;
    public AudioSource bong;

    //public GameObject img1;
    //public GameObject img2;
    //public GameObject img3;

    void Start()
    {
        envanter = FindObjectOfType<Envanter>();
        Bant = FindObjectOfType<bant>();
        bong = GetComponent<AudioSource>();

    //    img1 = GameObject.FindGameObjectWithTag("img1");
    //    img2 = GameObject.FindGameObjectWithTag("img2");
    //    img3 = GameObject.FindGameObjectWithTag("img3");

    //    img1.SetActive(false);
    //    img2.SetActive(false);
    //    img3.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "obje")
        {
            Bant.skor = Bant.skor + 10;
            bong.Play();
            Destroy(other.gameObject);
        }
    }
}
