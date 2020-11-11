using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Texture> ItemImages;

    public Dictionary<string, Item> Items;

    private void Awake()
    {
        BuildDatabase();
    }

    public void BuildDatabase()
    {
        Items = new Dictionary<string, Item>()
        {
            {"Test Dummy", new Item() { Name = "Test Dummy", Description = "Just a test dummy, jeez.", Image = ItemImages[0] } },

            {"Test Dummy2", new Item() { Name = "Test Dummy2", Description = "Just a test dummy, jeez.", Image = ItemImages[1] } },

            {"Test Dummy3", new Item() { Name = "Test Dummy3", Description = "Just a test dummy, jeez.", Image = ItemImages[2] } },
        };
    
    }

    public Item fetchItem(string name)
    {
        Item item = new Item(Items[name]);

        return item;
    }
}
