using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleClear : MonoBehaviour
{



    public void clearToggle(ToggleGroup toggleGroup)
    {
        if (toggleGroup.AnyTogglesOn())
            toggleGroup.SetAllTogglesOff();
    }

}