using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oyna : MonoBehaviour
{
    public Fade fade;


    void Start ()
    {
        fade = FindObjectOfType<Fade>();
    }

    public void OYNA ()
    {
        fade.LoadLevel(1);
    }
}