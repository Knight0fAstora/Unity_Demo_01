using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleMap_Manager : MonoSingleton<BattleMap_Manager>
{
    public List<BattleMap> BattleMaps;

    
    private void Start()
    {
        if(BattleMaps.Count > 0)
        { Debug.Log("Battle Map is instantiate"); }
    }


}
