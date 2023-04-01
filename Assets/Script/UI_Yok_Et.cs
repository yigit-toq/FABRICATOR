using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Yok_Et : MonoBehaviour
{
    public Text skorUI;
    public int skor;

    void Start ()
    {
        skor = PlayerPrefs.GetInt("YSkor");

        skorUI.text = skor.ToString();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "obje")
        {
            Destroy(other.gameObject);
        }
    }
}
