using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonnensystem_Position_zero : MonoBehaviour {


	void Update () {
        transform.localPosition = new Vector3 (0, transform.position.y, 0);
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
	}
}
