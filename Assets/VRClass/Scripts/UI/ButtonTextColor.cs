 using UnityEngine;  
 using System.Collections;  
 using UnityEngine.EventSystems;  
 using UnityEngine.UI;

public class ButtonTextColor : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public Text theText;
    public Color32 normalColor;
    public Color32 hoverColor;
  

    public void OnPointerEnter(PointerEventData eventData)
    {
        theText.color = hoverColor; //Or however you do your color
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        theText.color = normalColor; //Or however you do your color
    }

    public void changeColorToNormal()
    {
        theText.color = normalColor; //Or however you do your color
    }

}