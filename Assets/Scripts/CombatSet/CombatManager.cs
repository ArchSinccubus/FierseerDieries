using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum CombatStage { PlayerTurn, ActionPicked, ActionPlaying, EnemyTurn}

public class CombatManager : MonoBehaviour
{
    public PlayerCharacter AzmanChar;

    public EnemyCharacter[] Enemies;

    public List<CombatCharacter> TurnOrder;

    public Text APText;

    public void initCombat(EnemyCharacter[] Enemies)
    {
        
    }

    public void InitPlayer()
    {
        APText.text = AzmanChar.AP.ToString();
        
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
