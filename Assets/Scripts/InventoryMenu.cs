using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InventoryMenu : SubMenu
{



    public GameObject[] InventorySlots;

    public ItemDragger ItemPrefab;

    public override void init()
    {
        for (int i = 0; i < InventorySlots.Length && i < GameController.instance.Inventory.Count; i++)
        {
            ItemDragger item = Instantiate<ItemDragger>(ItemPrefab);

            item.itemDroppedEvent += ItemDroppedMethod;

            item.Image.sprite = GameController.instance.Inventory[i].Image;

            item.transform.SetParent(InventorySlots[i].transform);

            item.GetComponent<RectTransform>().localPosition = Vector3.zero;
        }
    }

    public override void exitMenu()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ItemDroppedMethod()
    { 
        
    }

    public void rearrangeItems()
    { 
        
    }

}
