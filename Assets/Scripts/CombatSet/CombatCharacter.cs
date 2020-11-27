using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatCharacter : MonoBehaviour
{
    //Stats
    public int Strength, Speed, HP, AC;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool hitAC()
    {
        return false;
    
    }

    public virtual void DoAction(CombatAction CA)
    { 
        
    }
}
