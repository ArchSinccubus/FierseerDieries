using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum CombatStage { PlayerTurn, ActionPicked, ActionPlaying, EnemyTurn}

public class CombatManager : MonoBehaviour
{
    public PlayerCharacter AzmanChar;

    public EnemyCharacter[] EnemiesArray;

    public List<CombatCharacter> SortedSpeedList,TurnOrderList;

    public Text APText;

    public ActionButtonManager[] battleButtonArray;

    

    public void initCombat(EnemyCharacter[] Enemies)
    {
        int MaxSpeed = SortForSpeed() + 1;


        for (int i = 1; i <= SortedSpeedList.Count; i++)
        {
            foreach (var item in SortedSpeedList)
            {
                if (i % (MaxSpeed - item.Speed) == 0)
                {
                    TurnOrderList.Add(item);
                }
            }
        }

        
    }

    public void initPlayer()
    {
        APText.text = AzmanChar.AP.ToString();

        for (int i = 0; i < battleButtonArray.Length; i++)
        {
            battleButtonArray[i].InitButton(AzmanChar.Actions[i]);
        }

    }

    public int SortForSpeed()
    {
        SortedSpeedList = new List<CombatCharacter>();

        SortedSpeedList.Add(AzmanChar);

        for (int i = 0; i < EnemiesArray.Length; i++)
        {
            bool IsDoneSearch = false;
            for (int j = 0; j < SortedSpeedList.Count && !IsDoneSearch; j++)
            {
                if (EnemiesArray[i].Speed > SortedSpeedList[j].Speed)
                {
                    SortedSpeedList.Insert(j, EnemiesArray[i]);
                    IsDoneSearch = true;
                }


            }

            if (!IsDoneSearch)
            {
                SortedSpeedList.Add(EnemiesArray[i]);
            }
        }

        return SortedSpeedList[0].Speed;
    
    }

    // Start is called before the first frame update
    void Start()
    {
        initCombat(EnemiesArray);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
