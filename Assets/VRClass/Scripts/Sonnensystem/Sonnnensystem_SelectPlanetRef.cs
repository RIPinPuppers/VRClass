using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonnnensystem_SelectPlanetRef : MonoBehaviour {


    public Transform cam;
    public Vector3 offset;
   
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = new Vector3(cam.transform.position.x, 0, cam.transform.position.z);
        transform.position += offset;
        transform.eulerAngles = new Vector3(0, cam.rotation.eulerAngles.y, 0);
      
	}
}
