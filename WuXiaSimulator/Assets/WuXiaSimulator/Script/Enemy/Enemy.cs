using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float CurrentHp;
    public float CurrentMp;

    public virtual void Battle()
    { }
}
