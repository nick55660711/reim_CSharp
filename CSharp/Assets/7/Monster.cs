using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("移動速度"), Range(0, 100)]
    public float speed;
    [Header("傷害值"), Range(10, 500)]
    public float damage;
    [Header("爆炸效果")]
    public GameObject explosion;
    [Header("死亡時間"), Range(0, 10)]
    public float deadTime;

    /// <summary>
    /// 移動
    /// </summary>
    protected void Move()
    {

        transform.Translate(speed * Time.deltaTime, 0, 0);

    }


    /// <summary>
    /// 爆炸
    /// </summary>
    protected void Explosion()
    {
       GameObject exp =  Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject); //刪除怪獸
        Destroy(exp, 2.5f);  //2.5秒後刪除爆炸效果
    }




    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "house")
        {

            collision.gameObject.GetComponent<house>().Damage(damage);
            Explosion();
        }
    }




    private void Awake()
    {
        Physics2D.IgnoreLayerCollision(8, 8);
    }

    protected virtual void Update()
    {
        Move();
    }








}
