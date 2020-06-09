﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObject : MonoBehaviour
{



   
    [Header("傷害值"), Range(10, 500)]
    public float damage;
    [Header("爆炸效果")]
    public GameObject explosion;

    /// <summary>
    /// 移動
    /// </summary>
   

    /// <summary>
    /// 爆炸
    /// </summary>
    private void Explosion()
    {
        GameObject exp = Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject); //刪除怪獸
        Destroy(exp, 2.5f);  //2.5秒後刪除爆炸效果
    }




    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "house")
        {
            collision.gameObject.GetComponent<house>().Damage(damage);
            Explosion();

        }
    }









}
