using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotateTagJahr : MonoBehaviour
{
    public Button lockedButton;
    public Transform parent;
    public GameObject day;
    public MeshRenderer dayMesh;
    public float degreesDay = -360f;
	public float durationDay = 1f;

    public float waitYear = 5f;

    public GameObject year;
    public MeshRenderer yearMesh;
    public float degreesYear = -3600f;
    public float durationYear = 3f;

    //public float waitReset = 5f;
    public float degreesReset = -7200f;
    public float durationReset = 5f;

    public AnimationCurve curve = AnimationCurve.Linear(0.0f, 0.0f, 1.0f, 1.0f);

    //float t = 0.0f;
    float yRot;

	public void startDayYear ()
	{
        dayMesh.enabled = false;
        yearMesh.enabled = false;
        day.SetActive(true);
        year.SetActive(true);

        StartCoroutine(RotateDay());
	}

    public void startDayYearDelay()
    {
        lockedButton.interactable = false;
        Invoke("startDayYear", 2);
    }

    public void resetRot()
    {
        StartCoroutine(ResetRotation());
    }

    IEnumerator RotateDay ()
	{
		Quaternion startRot = transform.rotation;
		float t = 0.0f;
		while (t < durationDay) {
			t += Time.deltaTime;
            float s = t / durationDay;
            yRot = Mathf.Lerp(0, degreesDay, curve.Evaluate(s));
            transform.rotation = startRot * Quaternion.AngleAxis(yRot, Vector3.up);

            if (yRot <= -180){
                dayMesh.enabled = true;
            }

            yield return null;
		}
		transform.rotation = startRot;
        day.transform.SetParent(null);
        StartCoroutine (Waiter1());
	}


    IEnumerator Waiter1() {
        yield return new WaitForSeconds(waitYear);
        StartCoroutine(RotateYear());
    }

    IEnumerator RotateYear()
    {
        Quaternion startRot = transform.rotation;
        float t = 0.0f;
        while (t < durationYear)
        {
            t += Time.deltaTime;
            //transform.rotation = startRot * Quaternion.AngleAxis (t / duration * degrees, Vector3.up); //or transform.right if you want it to be locally based
            float s = t / durationYear;
            yRot = Mathf.Lerp(0, degreesYear, curve.Evaluate(s));
            transform.rotation = startRot * Quaternion.AngleAxis(yRot, Vector3.up);
            float a = degreesYear + 180;
            if (yRot <= a)
            {
                yearMesh.enabled = true;
            }

            yield return null;
        }
        transform.rotation = startRot;
        year.transform.SetParent(null);
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
            yRot = Mathf.Lerp(0, degreesReset, curve.Evaluate(s));
            transform.rotation = startRot * Quaternion.AngleAxis(yRot, Vector3.up);

            yield return null;
        }

        year.transform.SetParent(parent, true);
        day.transform.SetParent(parent, true);
        //transform.rotation = startRot;


    }




}
