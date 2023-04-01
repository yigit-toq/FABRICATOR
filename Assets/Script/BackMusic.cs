using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMusic : MonoBehaviour
{

    public static BackMusic backMusic;

    void Awake ()
    {
        Tek_Yap();
    }

    void Tek_Yap ()
    {
        if (backMusic != null)
        {
            Destroy(gameObject);
        }
        else
        {
            backMusic = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
