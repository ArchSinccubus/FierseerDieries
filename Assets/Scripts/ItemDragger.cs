using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDragger : MonoBehaviour, IPointerUpHandler, IPointerDownHandler, IDragHandler, IEndDragHandler
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

    }


    public void OnPointerUp(PointerEventData eventData)
    {
        

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        
        this.GetComponent<RectTransform>().position = Input.mousePosition;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
    }
}
