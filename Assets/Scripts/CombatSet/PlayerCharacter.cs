using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : CombatCharacter
{
    public CombatAction[] Actions;

    public int AP;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool CanDoAction(CombatAction CA)
    {
        return AP - CA.APCost >= 0;
    }

    public override void DoAction(CombatAction CA)
    {
        if (CanDoAction(CA))
        {

        }
    }
}
