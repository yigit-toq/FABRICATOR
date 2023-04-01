using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Fırlatma_Sistemi : MonoBehaviour
{
    public bant Bant;
    public Envanter envanterKod;

    public float firlatmaSüresi;

    public bool firlat;

    public Transform tekerlekÜretici;
    public Transform tutacakÜretici;
    public Transform kafaÜretici;

    public GameObject tekerlek;
    public GameObject tutacak;
    public GameObject kafa;

    void Start()
    {
        firlatmaSüresi = 0f;

        firlat = true;
    }

    void Update()
    {
        if (firlat == false)
        {
            firlatmaSüresi = firlatmaSüresi - 2;
        }

        if (firlatmaSüresi == 0f)
        {
            firlat = true;
        }

        StartCoroutine (Kontroller ());
    }

    public IEnumerator Kontroller ()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && firlat && Bant.skor >= 0 && Bant.pause == false && Bant.can > 0)
        {
            yield return new WaitForSeconds (0.1f);
            Instantiate (tekerlek, tekerlekÜretici.position, Quaternion.identity);
            firlat = false;
            firlatmaSüresi = 100;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && firlat && Bant.skor >= 0 && Bant.pause == false && Bant.can > 0)
        {
            yield return new WaitForSeconds(0.1f);
            Instantiate(kafa, kafaÜretici.position, Quaternion.identity);
            firlat = false;
            firlatmaSüresi = 100;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3) && firlat && Bant.skor >= 0 && Bant.pause == false && Bant.can > 0)
        {
            yield return new WaitForSeconds(0.1f);
            Instantiate(tutacak, tutacakÜretici.position, Quaternion.identity);
            firlat = false;
            firlatmaSüresi = 100;
        }
    }
}
