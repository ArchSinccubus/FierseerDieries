using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowColliderManager : MonoBehaviour
{
    public int ArrowSceneID;

    public delegate void MoveToScene(int ID);

    public MoveToScene ArrowEvent;

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
        ArrowEvent(ArrowSceneID);

        //Debug.Log("testing123");
    }
}
