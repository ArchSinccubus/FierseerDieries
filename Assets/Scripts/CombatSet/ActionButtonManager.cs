using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionButtonManager : MonoBehaviour
{
    public SkillScriptableObject Action;

    public Text ButtonText;

    public void InitButton(SkillScriptableObject Action)
    {
        this.Action = Action;

        ButtonText.text = Action.Name;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClicked()
    {
        if (CombatManager.Instance.Stage == CombatStageEnum.PlayerTurn)
        {
            CombatManager.Instance.SetButtonsInactive(this);


            CombatManager.Instance.PickedAction = Action;
            CombatManager.Instance.Stage = CombatStageEnum.ActionPicked;
        }

        else if (CombatManager.Instance.Stage == CombatStageEnum.ActionPicked)
        {
            CombatManager.Instance.SetButtonsActive();


            CombatManager.Instance.PickedAction = null;
            CombatManager.Instance.Stage = CombatStageEnum.PlayerTurn;
        }

    }
}
