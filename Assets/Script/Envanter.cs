using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Envanter : MonoBehaviour
{
    public Fırlatma_Sistemi firlatmaSistemi;

    public static Vector2 fareKonum;

    [Header("İtem")]
    public GameObject item;
    public int itemID;
    public string itemAd;
    public string itemBilgi;

    public GameObject itemFrame;

    public Image tekerlekİmg;
    public Image kafaİmg;
    public Image tutacakİmg;

    public RectTransform tekerlekRect;
    public RectTransform kafaRect;
    public RectTransform tutacakRect;

    void Start()
    {
        itemID = 0;

        itemFrame.SetActive(true);

        tekerlekRect = tekerlekİmg.rectTransform;
        kafaRect = kafaİmg.rectTransform;
        tutacakRect = tutacakİmg.rectTransform;
    }

    void Update()
    {
        Kontroller ();

        if (itemID == 0)
        {
            itemFrame.SetActive(false);
        }
        else
        {
            itemFrame.SetActive(true);
        }

        kafaRect.sizeDelta = new Vector2(kafaRect.sizeDelta.x, firlatmaSistemi.firlatmaSüresi);
        tekerlekRect.sizeDelta = new Vector2(tekerlekRect.sizeDelta.x, firlatmaSistemi.firlatmaSüresi);
        tutacakRect.sizeDelta = new Vector2 (tutacakRect.sizeDelta.x, firlatmaSistemi.firlatmaSüresi);
    }

    void Kontroller ()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1) && firlatmaSistemi.firlat)
        {
            itemID = 1;
            itemAd = "Tekerlek";
            item = GameObject.FindGameObjectWithTag("item1");
            itemFrame.transform.localPosition = new Vector2(-226.5f, 0);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && firlatmaSistemi.firlat)
        {
            itemID = 2;
            itemAd = "Kafa";
            item = GameObject.FindGameObjectWithTag("item2");
            itemFrame.transform.localPosition = new Vector2(-86.5f,0);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3) && firlatmaSistemi.firlat)
        {
            itemID = 3;
            itemAd = "Tutacak";
            item = GameObject.FindGameObjectWithTag("item3");
            itemFrame.transform.localPosition = new Vector2(53.5f, 0);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            itemID = 4;
            itemAd = "Tornavida";
            item = GameObject.FindGameObjectWithTag("item4");
            itemFrame.transform.localPosition = new Vector2(225, 0);
        }
    }

    public void item1 ()
    {
        if (firlatmaSistemi.firlat && firlatmaSistemi.Bant.skor >= 0 && firlatmaSistemi.Bant.pause == false && firlatmaSistemi.Bant.can > 0)
        {
            itemID = 1;
            itemAd = "Tekerlek";
            item = GameObject.FindGameObjectWithTag("item1");
            itemFrame.transform.localPosition = new Vector2(-226.5f, 0);

            Instantiate(firlatmaSistemi.tekerlek, firlatmaSistemi.tekerlekÜretici.position, Quaternion.identity);
            firlatmaSistemi.firlat = false;
            firlatmaSistemi.firlatmaSüresi = 100; 
        }
    }

    public void item2()
    {
        if (firlatmaSistemi.firlat && firlatmaSistemi.Bant.skor >= 0 && firlatmaSistemi.Bant.pause == false && firlatmaSistemi.Bant.can > 0)
        {
            itemID = 2;
            itemAd = "Kafa";
            item = GameObject.FindGameObjectWithTag("item2");
            itemFrame.transform.localPosition = new Vector2(-86.5f, 0);

            Instantiate(firlatmaSistemi.kafa, firlatmaSistemi.kafaÜretici.position, Quaternion.identity);
            firlatmaSistemi.firlat = false;
            firlatmaSistemi.firlatmaSüresi = 100; 
        }
    }

    public void item3()
    {
        if (firlatmaSistemi.firlat && firlatmaSistemi.Bant.skor >= 0 && firlatmaSistemi.Bant.pause == false && firlatmaSistemi.Bant.can > 0)
        {
            itemID = 3;
            itemAd = "Tutacak";
            item = GameObject.FindGameObjectWithTag("item3");
            itemFrame.transform.localPosition = new Vector2(53.5f, 0);

            Instantiate(firlatmaSistemi.tutacak, firlatmaSistemi.tutacakÜretici.position, Quaternion.identity);
            firlatmaSistemi.firlat = false;
            firlatmaSistemi.firlatmaSüresi = 100; 
        }
    }

    public void item4()
    {
        itemID = 4;
        itemAd = "Tornavida";
        item = GameObject.FindGameObjectWithTag("item4");
        itemFrame.transform.localPosition = new Vector2(225, 0);
    }
}
