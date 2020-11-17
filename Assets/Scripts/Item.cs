using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class Item
{
    public string Name;
    public Sprite Image;
    public string Description;

    public Item()
    { 
        
    }

    public Item(Item i)
    {
        this.Name = i.Name;
        this.Image = i.Image;
        this.Description = i.Description;
    }

}
