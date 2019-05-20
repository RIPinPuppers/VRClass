using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeAlphaOut : MonoBehaviour
{
    Renderer rend;
    MeshRenderer rendMesh;

    void Start()
    {
        rendMesh = GetComponent<MeshRenderer>();
        rend = GetComponent<Renderer>();
        

    }

    IEnumerator FadeOut()
    {
        for (float f = 1f; f >= -0.05f; f -= 0.05f)
        {
            Color c = rend.material.color;
            c.a = f;
            rend.material.color = c;
            yield return new WaitForSeconds(0.025f);
        }

        rendMesh.enabled = false;
    

    }

    public void startFadeOut()
    {
        StartCoroutine("FadeOut");
    }

    public void startFadeOutDelay()
    {
        Invoke("startFadeOut", 1);
    }
}


