using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeAlphaIn : MonoBehaviour
{
    Renderer rend;
    MeshRenderer rendMesh;

    void Start()
    {
        rendMesh = GetComponent<MeshRenderer>();
        rend = GetComponent<Renderer>();
        Color c = rend.material.color;
        c.a = 0f;
        rend.material.color = c;

    }

    IEnumerator FadeIn()
    {
        rendMesh.enabled = true;
        for (float f = 0.05f; f <= 1; f += 0.05f)
        { 
            Color c = rend.material.color;
            c.a = f;
            rend.material.color = c;
            yield return new WaitForSeconds(0.025f);
        }

    }

    IEnumerator SetAlphaOn()
    {
        rendMesh.enabled = false;
        Color c = rend.material.color;
        c.a = 1;
        rend.material.color = c;
        yield return null;

    }

    public void startFadeIn()
    {
        StartCoroutine("FadeIn");
    }

    public void startFadeInDelay()
    {
        Invoke("startFadeIn", 1);
    }

    public void startAlphaOn()
    {
        StartCoroutine(SetAlphaOn());
    }
}



