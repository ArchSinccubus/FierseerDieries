using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDragger : MonoBehaviour, IPointerUpHandler, IPointerDownHandler, IDragHandler
{
    public delegate void ItemDropped();

    public ItemDropped itemDroppedEvent;

    public Image Image;

    bool Drag;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Drag)
        {
            this.GetComponent<RectTransform>().position = Input.mousePosition;
        }
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        itemDroppedEvent();
        Drag = false;

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Drag = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        
    }
}
