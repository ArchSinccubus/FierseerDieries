using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public Sprite Face;
    public string Text;

    public List<DialogueStruct> Lines;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

[Serializable]
public struct DialogueStruct
{
    public Sprite Face;
    public string Text;
}
