using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class bant : MonoBehaviour
{
    public Fade fade;
    public Objeler objeler;
    public Envanter envanter;
    public atilanObje atilanObje;
    public Ayarlar ayarlar;

    public float süre;

    public bool olusma;
    public bool pause;

    public GameObject dikkat;
    public GameObject olusanObje;
    public GameObject baslangic;
    public GameObject bitisEkranı;
    public GameObject can1;
    public GameObject can2;
    public GameObject can3;
    public GameObject can4;
    public GameObject can5;

    public Animator atici1;
    public Animator atici2;
    public Animator atici3;
    public Animator bitisAnim;
    public Animator bantAnim;

    public Text dikkatText;
    public Text skorText;
    public Text yuksekSkorText;
    public int yuksekSkor;
    public int skor;
    public int can;

    void Start ()
    {
        baslangic = GameObject.FindGameObjectWithTag("transform");

        bantAnim = GetComponent<Animator>();

        ayarlar = FindObjectOfType<Ayarlar>();
        fade = FindObjectOfType<Fade>();
        envanter = FindObjectOfType<Envanter>();
        objeler = FindObjectOfType <Objeler>();
        atilanObje = FindObjectOfType<atilanObje>();

        skor = 0;
        can = 5;

        bitisEkranı.SetActive(false);
        dikkat.SetActive(false);

        atici1.enabled = true;
        atici2.enabled = true;
        atici3.enabled = true;

        pause = false;

        yuksekSkor = PlayerPrefs.GetInt("YSkor");
    }

    void FixedUpdate()
    {
        if (süre < Random.Range(1000, 1200) && skor < 100 && skor >= 0f && !pause && can > 0)
        {
            süre++;
        }
        else if (skor < 100 && skor >= 0f && !pause && can > 0)
        {
            Instantiate(olusanObje, baslangic.transform.position, Quaternion.identity);
            süre = 0;
        }

        if (süre < Random.Range(800, 1000) && skor > 100 && skor < 300 && skor >= 0f && !pause && can > 0)
        {
            süre++;
        }
        else if (skor > 100 && skor < 300 && skor >= 0f && !pause && can > 0)
        {
            Instantiate(olusanObje, baslangic.transform.position, Quaternion.identity);
            süre = 0;
        }

        if (süre < Random.Range(600, 800) && skor > 300 && skor >= 0f && !pause && can > 0)
        {
            süre++;
        }
        else if (skor > 300 && skor >= 0f && !pause && can > 0)
        {
            Instantiate(olusanObje, baslangic.transform.position, Quaternion.identity);
            süre = 0;

            atici1.speed = 2f;
            atici2.speed = 2f;
            atici3.speed = 2f;
        }
        else
        {
            atici1.speed = 1f;
            atici2.speed = 1f;
            atici3.speed = 1f;
        }
    }

    void Update()
    {
        if (skor >= 0)
        {
            skorText.text = skor.ToString(); 
        }

        if (skor >= 200 && !pause && skor >= 0f && can > 0)
        {
            atici1.enabled = true;
            atici2.enabled = true;
            atici3.enabled = true;
            atici1.Play("Atici_Hareket");
            atici2.Play("Atici_Hareket_2");
            atici3.Play("Atici_Hareket_3");
        }
        else if (skor >= 200 || skor < 200)
        {
            atici1.enabled = false;
            atici2.enabled = false;
            atici3.enabled = false;
        }

        if (skor < 0)
        {
            bitisEkranı.SetActive(true);
            envanter.itemFrame.SetActive(false);
        }

        if (can == 5)
        {
            can1.SetActive(true);
            can2.SetActive(true);
            can3.SetActive(true);
            can4.SetActive(true);
            can5.SetActive(true);
        }

        if (can == 4)
        {
            can5.SetActive(false);
        }

        if (can == 3)
        {
            can4.SetActive(false);
        }

        if (can == 2)
        {
            can3.SetActive(false);
        }

        if (can == 1)
        {
            can2.SetActive(false);
        }

        if (can <= 0)
        {
            can1.SetActive(false);
            bitisEkranı.SetActive(true);
            bitisAnim.Play("Bitis");
            envanter.itemFrame.SetActive(false);
            if (skor > yuksekSkor) 
            {
                yuksekSkor = skor;
            }
            yuksekSkorText.text = yuksekSkor.ToString();
        }

        if (skor >= 0 && pause == false && can > 0)
        {
            bantAnim.SetBool("bant",true);
        }
        else
        {
            bantAnim.SetBool("bant", false);
        }

        if (can > 0 && skor >= 0 && Input.GetKeyDown(KeyCode.Escape))
        {
            StartCoroutine(Bitis_Ekranı_Giris());

            if (pause == true && Input.GetKeyDown(KeyCode.Escape))
            {
                StartCoroutine(Bitis_Ekranı_Cikis());
            }
        }
    }

    void OnCollisionStay2D (Collision2D other)
    {
        if (other.gameObject.tag == "obje" && skor >= 0 && pause == false && can > 0)
        {
            other.transform.position += new Vector3 (objeler.Hiz * Time.deltaTime, 0, 0);
        }
    }

    public void OnDestroy()
    {
        PlayerPrefs.SetInt("YSkor",yuksekSkor);
    }

    public void Replay ()
    {
        fade.LoadLevel(2);
    }

    public void Anamenu ()
    {
        fade.LoadLevel(0);
    }

    public void Pause ()
    {
        if (can > 0 && skor >= 0) 
        {
            StartCoroutine(Bitis_Ekranı_Giris());

            if (pause == true)
            {
                StartCoroutine(Bitis_Ekranı_Cikis());
            } 
        }
    }

    IEnumerator Bitis_Ekranı_Giris ()
    {
        bitisEkranı.SetActive(true);
        bitisAnim.Play("Bitis");
        yield return new WaitForSeconds (0.3f);
        pause = true;
    }

    IEnumerator Bitis_Ekranı_Cikis ()
    {
        bitisAnim.Play("Bitis_Fade");
        yield return new WaitForSeconds(0.3f);
        bitisEkranı.SetActive(false);
        pause = false;
    }
}
