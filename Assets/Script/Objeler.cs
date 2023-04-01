using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Objeler : MonoBehaviour
{
    public bant bantKod;

    public float Hiz;
    public float dikkatEkran;

    public bool ilerle;

    void Start()
    {
        bantKod = FindObjectOfType<bant>();

        ilerle = true;
    }
    void Update()
    {
        if (ilerle && bantKod.skor >= 0 && bantKod.pause == false && bantKod.can > 0)
        {
            transform.position += new Vector3(Hiz * Time.deltaTime, 0, 0);
        }

        if (bantKod.skor >= 0 && bantKod.pause == false && bantKod.skor < 100)
        {
            Hiz = 4f;
        }

        if (bantKod.skor >= 100 && bantKod.pause == false && bantKod.skor < 300)
        {
            Hiz = 4.5f;
        }

        if (bantKod.skor >= 300 && bantKod.pause == false && bantKod.skor < 500)
        {
            Hiz = 5f;
        }

        if (bantKod.skor >= 500 && bantKod.pause == false)
        {
            Hiz = 5.5f;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "dur")
        {
            ilerle = false;
            Destroy(gameObject);
        }
    }

    void OnTriggerStay2D (Collider2D other)
    {
        if (other.gameObject.tag == "1") 
        {
            bantKod.dikkat.SetActive(true);
            dikkatEkran = 1f;
            bantKod.dikkatText.text = dikkatEkran.ToString();
        }

        if(other.gameObject.tag == "2")
        {
            bantKod.dikkat.SetActive(true);
            dikkatEkran = 2f;
            bantKod.dikkatText.text = dikkatEkran.ToString();
        }

        if(other.gameObject.tag == "3")
        {
            bantKod.dikkat.SetActive(true);
            dikkatEkran = 3f;
            bantKod.dikkatText.text = dikkatEkran.ToString();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "1" || other.gameObject.tag == "2" || other.gameObject.tag == "3")
        {
            bantKod.dikkat.SetActive(false);
        }
    }
}
