using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameScene : MonoBehaviour
{


    public SceneObject[] Objects;

    public int SceneID;

    public GameObject ArrowLeft, ArrowRight, ArrowUp;

    public bool ArrowsVisible;

    //public UnityEvent clickEvent;

    public void init()
    {
        List<ArrowColliderManager> list = new List<ArrowColliderManager>();

        list.AddRange(ArrowLeft.GetComponentsInChildren<ArrowColliderManager>());

        list.AddRange(ArrowRight.GetComponentsInChildren<ArrowColliderManager>());

        list.AddRange(ArrowUp.GetComponentsInChildren<ArrowColliderManager>());

        foreach (var item in list)
        {
            item.ArrowEvent += SceneTransition;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseEnter()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit)
        {
            if (hit.collider.tag == "Scene" && !ArrowsVisible)
            {
            ArrowLeft.transform.position += new Vector3(2, 0, 0);
            ArrowRight.transform.position += new Vector3(-2, 0, 0);
            ArrowUp.transform.position += new Vector3(0, -2, 0);
                ArrowsVisible = true;
            }
        }
    }

    private void OnMouseExit()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (!hit)
        {
            ArrowsVisible = false;
        }
        else if(hit.collider.tag != "Arrows")
        {
            ArrowsVisible = false;
        }
        if (!ArrowsVisible)
            {
                ArrowLeft.transform.position += new Vector3(-2, 0, 0);
                ArrowRight.transform.position += new Vector3(2, 0, 0);
                ArrowUp.transform.position += new Vector3(0, 2, 0);
                //ArrowsVisible = false;
            }
    }

    public void SceneTransition(int SceneID)
    {
        GameController.instance.SceneTransition(this.SceneID, SceneID);
    }


    public void AddToJournal()
    { }

    public void AddItem(String ItemID)
    { }

    public void RemoveItem(Item I)
    { }

    public void StartObjectEffect()
    { }

    public void OpenDialogue(Dialogue Di)
    {
        DialogueBoxManager DB = GameController.instance.DB;

        DB.init(Di);
    }
}
