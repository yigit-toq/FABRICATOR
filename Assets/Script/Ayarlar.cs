using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ayarlar : MonoBehaviour
{
    public Animator anim;

    public Text kalite;

    public AudioSource arkaplanSes;

    public Slider volumeSlider;

    public float sesSeviye = 1f;

    void Start()
    {
        arkaplanSes = GameObject.FindGameObjectWithTag("music").GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        gameObject.SetActive(false);
        arkaplanSes.Play();
    }

    void Update ()
    {
        arkaplanSes.volume = sesSeviye;
    }

    public void Kapat ()
    {
        StartCoroutine(kapat());
    }

    public void AyarlarMenu ()
    {
        gameObject.SetActive(true);
        anim.Play("Ayarlar");
    }

    public void Low ()
    {
        QualitySettings.SetQualityLevel(1);
        kalite.text = "QUALITY: LOW";
    }

    public void Medium ()
    {
        QualitySettings.SetQualityLevel(3);
        kalite.text = "QUALITY: MEDIUM";
    }

    public void High ()
    {
        QualitySettings.SetQualityLevel(6);
        kalite.text = "QUALITY: HIGH";
    }

    IEnumerator kapat ()
    {
        anim.Play("AyarlarGidis");
        yield return new WaitForSeconds(0.1f);
        gameObject.SetActive(false);
    }

    public void sesAyarlar ()
    {
        sesSeviye = volumeSlider.value;
    }
}
