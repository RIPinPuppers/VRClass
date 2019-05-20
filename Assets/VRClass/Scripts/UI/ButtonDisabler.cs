using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDisabler : MonoBehaviour
{



    public void disableButton(Button selectedbutton)
    {
        selectedbutton.interactable = false;
    }

    public void enableButton(Button selectedbutton)
    {
        selectedbutton.interactable = true;
    }

}