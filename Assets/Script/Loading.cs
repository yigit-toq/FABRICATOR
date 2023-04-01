using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    public Fade fade;

    public Slider progressBar;

    void Start()
    {
        fade = FindObjectOfType<Fade>();
        StartCoroutine(startLoading());
    }

    IEnumerator startLoading ()
    {
        AsyncOperation async = SceneManager.LoadSceneAsync(2);
        while (!async.isDone) 
        {
            progressBar.value = async.progress;
            yield return null; 
        }
    }
}
