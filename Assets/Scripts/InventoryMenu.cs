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

            item.GetComponent<Image>().image = GameController.instance.Inventory[i].Image;
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

}
