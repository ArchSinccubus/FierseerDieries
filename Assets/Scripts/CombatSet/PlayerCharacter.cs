using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : CombatCharacter
{

    public int AP;

    private int currAP;
    public int CurrAP
    {
        get => currAP; set

        {
            if (currAP != value)
            {
                APChanged();
            }

            if (value > AP)
            {
                currAP = AP;
            }
            else if (value < 0)
            {
                currAP = value;
            }
            else
            {
                currAP = value;
            }

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

    public bool CanDoAction(CombatAction CA)
    {
        return CurrAP - CA.APCost >= 0;
    }

    public override void DoAction(CombatAction CA)
    {
        if (CanDoAction(CA))
        {

        }
    }

    public override void StartTurn()
    {
        CurrAP = AP;
    }

    public void APChanged()
    { 
    
    }
}
