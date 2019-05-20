using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputClear : MonoBehaviour
{

    
    
    public void clearInput(InputField inputfield)
    {
        inputfield.text = "";
    }

}