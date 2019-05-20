using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translateNeigungNeedle : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;

    public AnimationCurve moveCurve;

    public void startMovingNeedle()
    {
        StartCoroutine(MoveNeedle());
    }

    public void startMovingNeedleDelay()
    {
        Invoke("startMovingNeedle", 2);
    }
    


    IEnumerator MoveNeedle()
    {
        
        if(transform.position == pointB.position)
        {
            yield return StartCoroutine(MoveObject(transform, pointB.position, pointA.position, 0.5f));

           
        }

        else
        {
            yield return StartCoroutine(MoveObject(transform, pointA.position, pointB.position, 1.0f));
        }


    }

    IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos,  float time)
    {
        var i = 0.0f;
        var rate = 1.0f / time;
        while (i < 1.0f)
        {
            i += Time.deltaTime * rate;
            thisTransform.position = Vector3.Lerp(startPos, endPos, moveCurve.Evaluate(i));
            yield return null;
        }
    }

}