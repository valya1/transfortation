using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MyButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("sdfsdfsdfsdf");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("WHATACHUDO");
    }
}
