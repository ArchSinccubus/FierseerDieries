using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionButtonManager : MonoBehaviour
{
    public CombatAction Action;

    public Text ButtonText;

    public void InitButton(CombatAction Action)
    {
        this.Action = Action;

        ButtonText.text = Action.name;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
