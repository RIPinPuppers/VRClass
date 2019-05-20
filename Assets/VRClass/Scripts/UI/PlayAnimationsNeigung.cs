using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimationsNeigung : MonoBehaviour
{
    public Animator animatedPlanet;
    public Animator animatedNeedle;

    //void Start()
    //{
    //    animatedPlanet = GetComponent<Animator>();
    //    animatedNeedle = GetComponent<Animator>();
    //}


    public void playAnimationNeigung()

    {
        animatedPlanet.Play("neigung", 0, 0);
        animatedNeedle.Play("neigung_needle", 0, 0);
    }


    public void exitAnimationNeigung()
    {
        animatedPlanet.Play("exit", 0, 0);
        animatedNeedle.Play("exit", 0, 0);
    }


    public void playAnimationNeigungDelay()
    {
        Invoke("playAnimationNeigung", 2);
    }

    public void exitAnimationNeigungDelay()
    {
        Invoke("exitAnimationNeigung", 1);
    }

}
   