using Assets.Scripts.CombatSet.SkillS;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StatEnum { Strength, Speed, CurrHP, Defense, AP }


public abstract class CombatCharacter : MonoBehaviour
{

    //Stats
    public int Strength, Speed, HP, Defense;

    Dictionary<StatEnum, float> localStats;

    public LifeBarController HPBar;

    public SkillScriptableObject[] Actions;

    public List<SkillEffect> ContinousEffectsList;

    public virtual void InitForBattle()
    {
        localStats.Add(StatEnum.CurrHP, HP);

        HPChanged();

        localStats.Add(StatEnum.Defense, Defense);
        localStats.Add(StatEnum.Speed, Speed);
        localStats.Add(StatEnum.Strength, Strength);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public virtual void StartTurn()
    {
        for (int i = 0; i < ContinousEffectsList.Count; i++)
        {
            if (ContinousEffectsList[i].EffectAmount >= 0)
            {
                ApplyEffect(ContinousEffectsList[i]);
            }
            else
            {
                ContinousEffectsList.RemoveAt(i);
                i--;
            }
        }

        
    }

    public virtual void DoAction(CombatAction CA)
    {

    }

    void HPChanged()
    {
        HPBar.CalculateHPDiff(HP, localStats[StatEnum.CurrHP]);
        
    }

    void regulateHP(float value)
    {
        if (value > HP)
        {
            localStats[StatEnum.CurrHP] = HP;
            HPChanged();
        }

        else if (value < 0)
        {
            localStats[StatEnum.CurrHP] = 0;
            HPChanged();
            Die();
        }
    }


    void ApplyEffect(SkillEffect effect)
    {
        if (effect.Percentage)
        {
            localStats[effect.EnemyAffectedStat] = returnMainStat(effect.EnemyAffectedStat) * (1 - (effect.EffectAmount / 100f));
        }
        else
        {
            localStats[effect.EnemyAffectedStat] -= effect.EffectAmount;
        }

        if (effect.EnemyAffectedStat == StatEnum.CurrHP)
        {
            regulateHP(localStats[StatEnum.CurrHP]);
        }
    }

    public int returnMainStat(StatEnum stat)
    {
        switch (stat)
        {
            case StatEnum.CurrHP: 
                return HP;

            case StatEnum.Defense:
                return Defense;

            case StatEnum.Strength:
                return Strength;

            case StatEnum.Speed:
                return Speed;

            case StatEnum.AP:
                return (this as PlayerCharacter).AP;
        }

        return 0;
        
    }

    public virtual void Die()
    { 
    
    }
}
