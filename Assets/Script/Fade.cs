using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
    public static Fade fade;

    public Animator fadeAnim;

    public GameObject fadePanel;

    public int sahne;
    
    void Awake ()
    {
        Tek_Yap ();
    }

    void Tek_Yap ()
    {
        if (fade != null)
        {
            Destroy(gameObject);
        }
        else
        {
            fade = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void LoadLevel(int bolum)
    {
        StartCoroutine(FadeInOut(bolum));
    }

    IEnumerator FadeInOut(int bolum)
    {
        fadePanel.SetActive(true);
        fadeAnim.Play("FadeIn");
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(bolum);
        fadeAnim.Play("FadeOut");
        yield return new WaitForSeconds(0.1f);
        fadePanel.SetActive(false);
    }
}
