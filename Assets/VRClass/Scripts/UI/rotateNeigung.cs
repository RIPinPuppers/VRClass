using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotateNeigung : MonoBehaviour
{
    public Button lockedButton;
    public float degreesNeigung = -25f;
    public float durationNeigung = 1f;

    public float degreesReset = -25f;
    public float durationReset = 1f;
    

    public AnimationCurve curve = AnimationCurve.Linear(0.0f, 0.0f, 1.0f, 1.0f);

    //float t = 0.0f;
    float zRot;


    public void startNeigung()
    {

        StartCoroutine(RotateNeigung());
    }

    public void startNeigungDelay()
    {
        lockedButton.interactable = false;
        Invoke("startNeigung", 2);
    }

    public void resetRot()
    {
        StartCoroutine(ResetRotation());
    }

    IEnumerator RotateNeigung()
    {
        Quaternion startRot = transform.rotation;
        float t = 0.0f;
        while (t < durationNeigung)
        {
            t += Time.deltaTime;
            float s = t / durationNeigung;
            zRot = Mathf.Lerp(0, degreesNeigung, curve.Evaluate(s));
            transform.rotation = startRot * Quaternion.AngleAxis(zRot, Vector3.forward);

            yield return null;
        }
        //transform.rotation = startRot;
        StartCoroutine(ButtonUnlock());

    }

    IEnumerator ButtonUnlock()
    {
        lockedButton.interactable = true;
        yield return null;
    }

    IEnumerator ResetRotation()
    {

        Quaternion startRot = transform.rotation;
        float t = 0.0f;
        while (t < durationReset)
        {
            t += Time.deltaTime;
            float s = t / durationReset;
            zRot = Mathf.Lerp(0, degreesReset, curve.Evaluate(s));
            transform.rotation = startRot * Quaternion.AngleAxis(zRot, Vector3.forward);

            yield return null;
        }

        //transform.rotation = startRot;


    }
}


