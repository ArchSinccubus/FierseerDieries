using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public List<Item> Inventory;

    public int Saponatas;

    public GameScene[] Scenes;

    public MainMenuController MainMenu;

    public DialogueBoxManager DB;

    public static GameController instance;

    public ItemDatabase ItemDatabase;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        MainMenu.init();
        foreach (var item in Scenes)
        {
            item.init();
        }
        MainMenu.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void SceneTransition(int OrigSceneID, int NewSceneID)
    {
        Scenes[OrigSceneID].gameObject.SetActive(false);

        Scenes[NewSceneID].gameObject.SetActive(true);
    }

    private void OnMouseEnter()
    {
        MainMenu.gameObject.SetActive(true);
    }

    #region SceneActions
    public void AddToJournal()
    { }

    public void AddItem(String ItemID)
    {
        Item I = new Item(ItemDatabase.fetchItem(ItemID));

        Inventory.Add(I);
    }

    public void RemoveItem(Item I)
    {

    }

    public void StartObjectEffect()
    {

    }

    public void AddMoney(int Amount)
    {
        Saponatas += Amount;
    }

    public bool RemoveMoney(int Amount)
    {
        if (Saponatas - Amount >= 0)
        {
            Saponatas -= Amount;
            return true;
        }

        return false;
    }

    public void OpenDialogue(Dialogue Di)
    {
        DB.init(Di);
    } 
    #endregion

}
