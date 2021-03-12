using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalEnemy : Enemy
{
    BoxCollider2D boxCollider;

    void Start()
    {
        Debug.Log("this enmey's currentHp = " + CurrentHp);
        Debug.Log("this enmey's currentHp = " + CurrentMp);
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag(StaticString.Tag_Player))
        {
            Debug.Log("get player into battle ground");
            //load battle map
        }
    }



}
