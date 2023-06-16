using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Hover : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    public bool isOver = false;
   // private Color initialColor;
    public void start()
    {
      //  initialColor = GetComponent<Image>().color;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse enter");
        isOver = true;

        gameObject.GetComponent<Image>().color = Color.magenta;
        //eventData.pointerEnter.gameObject.GetComponent<Image>().color = Color.green;

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Mouse exit");
        isOver = false;
        //GetComponent<Image>().color = initialColor;
        gameObject.GetComponent<Image>().color = Color.HSVToRGB(5,34,65,false);
    }

    /*  void OnMouseOver()
      {
          //If your mouse hovers over the GameObject with the script attached, output this message
          Debug.Log("Mouse is over GameObject.");
          gameObject.GetComponent<Image>().color = Color.green;
      }

      void OnMouseExit()
      {
          //The mouse is no longer hovering over the GameObject so output this message each frame
          Debug.Log("Mouse is no longer on GameObject.");
          gameObject.GetComponent<Image>().color = initialColor;
      }*/
}