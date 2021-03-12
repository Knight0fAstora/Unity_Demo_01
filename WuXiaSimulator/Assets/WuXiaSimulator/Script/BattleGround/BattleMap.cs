using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleMap : MonoBehaviour
{
    public Sprite Map
    {
        get
        {
            return _map;
        }
    }

    private Sprite _map;

    void Start()
    {
        if(_map = null)
        {
            _map = GetComponent<Sprite>();
        }
    }

    //更换地图资源方法
    public void ChangeMap(Sprite map)
    {
        _map = map;
    }

    //读取地图资源之后，战斗区域系统资源分配
    public void InitMap()
    {

    }
}
