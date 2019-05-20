using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayAngle : MonoBehaviour {

    public Text DegreeText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float AngleZ = transform.localEulerAngles.z;
        float newAngleZ = Mathf.Abs(AngleZ - 360f);
        if (newAngleZ >= 359)
        {
            newAngleZ = 0f;
        }
        
        DegreeText.text = newAngleZ.ToString("F1") + " " + "°";
	}
}
