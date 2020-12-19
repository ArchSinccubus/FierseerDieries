using Assets.Scripts.CombatSet.SkillS;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Skill", menuName = "ScriptableObjects/Skill", order = 1)]
public class SkillScriptableObject : ScriptableObject
{
    public int APCost;
    public string Name;
    public string Description;

    public SkillEffect[] Effects;

    public bool SingleTarget;
    public List<CombatCharacter> Target;
    public bool FinishTurn;
}
