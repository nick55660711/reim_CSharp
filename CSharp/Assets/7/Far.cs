using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Far : Ground
{
    [Header("停止距離"), Range(0, 10)]
    public float StopDistance;
    [Header("丟擲物品")]
    public GameObject prop;
    [Header("丟擲間隔時間"), Range(0, 5)]
    public float cd;


    private Transform target;
    private float Timer;
    /// <summary>
    /// 繪製圖示事件：在 Scene繪製圖示，遊戲內不會顯示
    /// </summary>
    private void OnDrawGizmos()
    {
        //圖示.顏色 = 顏色(R,G,B,A)
        

        Gizmos.color = new Color(1, 0, 0, 0.5f);

        // 圖示.繪製線條(起點,終點)
        Gizmos.DrawLine(transform.position, transform.position + transform.right * StopDistance );


    }

        

    private void Start()
    {
        target = GameObject.Find("house").transform;

    }

    private void Throw() 
    {
        float dis = Vector3.Distance(transform.position, target.position);
        if (dis < StopDistance)
        {
            speed = 0;
            Timer += Time.deltaTime;

            if (Timer>=cd) 
            {

                Timer = 0;
                GameObject temp = Instantiate(prop, transform.position + (transform.right + transform.up) * 0.8f, Quaternion.identity);
                temp.GetComponent<Rigidbody2D>().AddForce(new Vector2(300, 150));
            }
        }
        Invoke("Explosion", deadTime); // 延遲呼叫方法("方法名稱",延遲時間)
    }

    protected override void Update()
    {
        base.Update();
        Throw ();



    }




}



