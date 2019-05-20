using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFade : MonoBehaviour
{
    public GameObject canvasObjectOut;
    public CanvasGroup canvasOut;
    public float startAlphaOut;
    public float endAlphaOut;
    public float durationOut;
    public GameObject canvasObjectIn;
    public CanvasGroup canvasIn;
    public float startAlphaIn;
    public float endAlphaIn;
    public float durationIn;
    private bool callOnce = false;


    public void ExampleDelay()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        print(Time.time);
        yield return new WaitForSeconds(2);
        print(Time.time);
    }

    public void FadePanel()
    {
        if (callOnce == false)
        {
            
            FadePanelOut();
            Invoke("FadePanelIn", 1);
        }

    }


    public void FadePanelOut()
    {
        StartCoroutine(FadeCanvasOutCoroutine());
    }

    public void FadePanelInDelay()
    {
        Invoke("FadePanelIn", 1);
    }
    public void FadePanelIn()
    {
        StartCoroutine(FadeCanvasInCoroutine());
    }

    private IEnumerator FadeCanvasOutCoroutine()
    {
        if (endAlphaOut == 0)
        {
            canvasOut.interactable = false;

        }
        callOnce = false;
        // keep track of when the fading started, when it should finish, and how long it has been running&lt;/p&gt; &lt;p&gt;&a
        var startTime = Time.time;
        var endTime = Time.time + durationOut;
        var elapsedTime = 0f;

        // set the canvas to the start alpha – this ensures that the canvas is ‘reset’ if you fade it multiple times
        canvasOut.alpha = startAlphaOut;
        // loop repeatedly until the previously calculated end time
        while (Time.time <= endTime)
        {
            elapsedTime = Time.time - startTime; // update the elapsed time
            var percentage = 1 / (durationOut / elapsedTime); // calculate how far along the timeline we are
            if (startAlphaOut > endAlphaOut) // if we are fading out/down 
            {
                canvasOut.alpha = startAlphaOut - percentage; // calculate the new alpha
            }
            else // if we are fading in/up
            {
                canvasOut.alpha = startAlphaOut + percentage; // calculate the new alpha
            }

            yield return new WaitForEndOfFrame(); // wait for the next frame before continuing the loop
        }
        canvasOut.alpha = endAlphaOut; // force the alpha to the end alpha before finishing – this is here to mitigate any rounding errors, e.g. leaving the alpha at 0.01 instead of 0

        if (endAlphaOut == 0)
        {
            canvasObjectOut.SetActive(false);

        }

        yield return null;

    }

    private IEnumerator FadeCanvasInCoroutine()
    {
    

        if (startAlphaIn == 0)
        {
            canvasObjectIn.SetActive(true);

        }

        if (canvasObjectIn.activeSelf == true)
        {
            canvasIn.interactable = true;

        }
        callOnce = false;
        // keep track of when the fading started, when it should finish, and how long it has been running&lt;/p&gt; &lt;p&gt;&a
        var startTime = Time.time;
        var endTime = Time.time + durationOut;
        var elapsedTime = 0f;

        canvasIn.alpha = startAlphaIn;


        // loop repeatedly until the previously calculated end time
        while (Time.time <= endTime)
        {
            elapsedTime = Time.time - startTime; // update the elapsed time
            var percentage = 1 / (durationIn / elapsedTime); // calculate how far along the timeline we are
            if (startAlphaIn > endAlphaIn) // if we are fading out/down 
            {
                canvasIn.alpha = startAlphaIn - percentage; // calculate the new alpha
            }
            else // if we are fading in/up
            {
                canvasIn.alpha = startAlphaIn + percentage; // calculate the new alpha
            }

            yield return new WaitForEndOfFrame(); // wait for the next frame before continuing the loop
        }
        canvasIn.alpha = endAlphaIn; // force the alpha to the end alpha before finishing – this is here to mitigate any rounding errors, e.g. leaving the alpha at 0.01 instead of 0

        

        yield return null;
    }

}