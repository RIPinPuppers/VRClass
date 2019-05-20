using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationAufbau : MonoBehaviour {

    //public Animator animatedPlanet;
    public GameObject animatedPlanet;


    public void playAnimationAufbau()

    {
        animatedPlanet.GetComponent<Animator> ().Play("openPlanet", 0, 0);
    }

    public void playAnimationAufbauReverse ()
    {
        
        animatedPlanet.GetComponent<Animator> ().Play("closePlanet", 0, 0f);
    }




    public void playAnimationAufbauDelay()
    {
        Invoke("playAnimationAufbau", 2);
    }

    public void playAnimationAufbauReverseDelay()
    {
        Invoke("playAnimationAufbauReverse", 1);
    }

}


