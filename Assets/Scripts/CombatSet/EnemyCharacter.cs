using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCharacter : CombatCharacter
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void DoAction(CombatAction CA)
    {

    }

    private void OnMouseDown()
    {
        if (CombatManager.Instance.Stage == CombatStageEnum.ActionPicked)
        {
            CombatManager.Instance.PickedAction.Target.Add(this);
        }
    }
}
