using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atilanObje : MonoBehaviour
{
    public bant bantKod;
    public Envanter envanterKod;
    //public Yok_Et yokEt;

    public bool banta_degiyor;

    void Start()
    {
    //  yokEt = FindObjectOfType<Yok_Et>();
        bantKod = FindObjectOfType<bant>();
        envanterKod = FindObjectOfType<Envanter>();
        banta_degiyor = false;
    }

    void OnCollisionEnter2D (Collision2D other)
    {
        if (other.gameObject.tag == "bant" && bantKod.skor >= 0 && bantKod.can > 0 && !bantKod.pause)
        {
            if (banta_degiyor == false) 
            {
                bantKod.can = bantKod.can - 1;
            }

            banta_degiyor = true;
        }

        //if (other.gameObject.tag == "yoket")
        //{
        //    if (envanterKod.itemID == 1)
        //    {
        //        yokEt.img1.SetActive(true);
        //    }
        //
        //    if (envanterKod.itemID == 2)
        //    {
        //    yokEt.img2.SetActive(true);
        //    }
        //
        //    if (envanterKod.itemID == 3)
        //    {
        //    yokEt.img3.SetActive(true);
        //    }
}

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "dur")
        {
            if (banta_degiyor)
            {
                bantKod.skor = bantKod.skor - 10;
                Destroy (this.gameObject);
            }
        }
    }

    void OnMouseDrag ()
    {
        if (envanterKod.itemID == 4)
        {
            Destroy(this.gameObject);
        }
    }
}
