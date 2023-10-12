using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClickAndDrag : MonoBehaviour, IDragHandler
{
    public void OnDrag(PointerEventData eventData){
        Debug.Log("hi");
        transform.position = eventData.position;
        //transform.SetAsLastSibling();
    }

}