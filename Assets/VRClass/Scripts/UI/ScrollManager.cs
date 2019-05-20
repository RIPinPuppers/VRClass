using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollManager : MonoBehaviour
{



    public void resetScroll(Scrollbar scrollbar)
    {
        scrollbar.value = 1;
    }

}
