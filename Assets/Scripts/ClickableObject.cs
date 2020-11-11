using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ClickableObject : SceneObject
{
    public bool glowWhenClick;

    [SerializeField]
    protected UnityEvent clickEvent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        clickEvent.Invoke();
        Debug.Log("AAAAAAAAAAA");
    }

    private void OnMouseEnter()
    {
        if (glowWhenClick)
        {
            changeColor(Color.yellow);
        }

    }

    private void OnMouseExit()
    {
        if (glowWhenClick)
        {
            resetColor();

        } 
    }
}
