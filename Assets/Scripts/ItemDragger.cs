using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDragger : MonoBehaviour
{
    public delegate void ItemDropped();

    public ItemDropped itemDroppedEvent;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnMouseDrag()
    {

    }

    private void OnMouseUp()
    {
        itemDroppedEvent();
    }
}
