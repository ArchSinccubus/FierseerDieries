using Assets.Scripts.CombatSet.SkillS;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StatEnum { Strength, Speed, CurrHP, AC, AP }


public abstract class CombatCharacter : MonoBehaviour
{

    //Stats
    public int Strength, Speed, HP, AC;

    private int currHP;

    public LifeBarController HPBar;

    public SkillScriptableObject[] Actions;

    public List<SkillEffect> ContinousEffectsList;

    public int CurrHP { get => currHP; set
        {
            if (value > HP)
            {
                currHP = HP;
            }
            else if (value < 0)
            {
                currHP = value;
            }
            else
            {
                currHP = value;
            }

            HPChanged();
        }
    }

    public virtual void InitForBattle()
    {
        currHP = HP;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool HitAC()
    {
        return false;

    }

    public virtual void StartTurn()
    { 
        
    }

    public virtual void DoAction(CombatAction CA)
    {

    }

    void HPChanged()
    {
        HPBar.CalculateHPDiff(HP, currHP);
    }

    void ApplyEffect(SkillEffect effect)
    { 
    
    }

    public void GetStatFromEnum(StatEnum stat)
    { 

    }

    public virtual void Die()
    { 
    
    }
}
