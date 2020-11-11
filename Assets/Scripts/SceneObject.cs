using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SceneObject : MonoBehaviour
{
    [SerializeField]
    protected SpriteRenderer S;

    [SerializeField]
    protected Color BaseColor;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected IEnumerator glow()
    {
        yield return null;
    }

    protected void changeColor(Color C)
    {
        S.color = C;
            
    }

    protected void resetColor()
    {

        S.color = BaseColor;

    }
}
