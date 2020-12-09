using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Element { Phyiscal, fire, superFire, ExtraFire, MegaFire, BurnYourAssOffFire }

public enum ActionTypes { Defend, Attack, DirectDamage, Heal, DirectHealing, Status, Steal, Pass, OpenSubMenu }


[Serializable]
public class CombatAction
{
    public int APCost;
    public string name;
    public string Description;
    public int Damage;
    public Element DamateType;

    public bool SingleTarget;
    public List<CombatCharacter> Target;
}
