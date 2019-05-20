using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonnensystem_RotationHalten : MonoBehaviour {


    public Vector3 startPos;
   

    void Update()
    {
        transform.eulerAngles = new Vector3(0, transform.rotation.y, 0);
        transform.position = new Vector3(transform.position.x, startPos.y, transform.position.z);

    }

  
}
