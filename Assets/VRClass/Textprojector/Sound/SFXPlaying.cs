using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlaying : MonoBehaviour {

    public AudioSource NewMessage;

    public void PlayNewMessage(){
        NewMessage.Play ();
    }
}
