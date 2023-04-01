using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UI_Kodlar : MonoBehaviour
{
    public float süre;
    public int saniye;

    public Text süreText;

    void Update()
    {
        süre += Time.deltaTime;
        süreText.text = saniye.ToString();

        if (süre >= 1)
        {
            saniye++;
            süre = 0;
        }
    }
}
