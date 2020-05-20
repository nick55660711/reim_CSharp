using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Class6_StaticAPI : MonoBehaviour
{
    //物件
    public Enemy zombie1, zombie2;
    // 修飾詞 非靜態成員類別 物件名稱
    public GameObject obj1;
    public Light myLight;
    public Transform tran1;

    public SpriteRenderer kid;

    public Rigidbody ball;
    private void Start()
    {
        #region 練習靜態
        // 一般欄位
        // 取得方式：物件.欄位
        print(zombie1.name + "血量：" + zombie1.hp);
        print(zombie2.name + "血量：" + zombie2.hp);

        // 靜態欄位
        // 取得方式：類別.靜態欄位
        print("僵屍的速度：" + Enemy.speed);

        // 無法透過物件取得靜態欄位 (錯誤)
        // print(zombie1.speed);


        // 使用一般方法
        // 物件.方法
        zombie1.Walk();
        zombie2.Walk();

        // 使用靜態方法
        // 類別.方法
        Enemy.Stop();

        // 無法透過物件取得靜態方法 (錯誤)
        // zombie.Stop();
        #endregion

        // API 靜態成員
        // 存放 靜態 屬性
        // 類別.靜態屬性 = 值
        Cursor.visible = false ;

        // 取得 靜態 屬性
        print(Mathf.PI);

        // 取得 隨機.值
        print(Random.value);

        // 使用靜態方法
        // 類別.靜態方法 (對應的引數)
        print("絕對值：" + Mathf.Abs(-77.7f));
        
        print("隨機範圍：" + Random.Range(1f,100f));
        
        // 整數不傳回最大值
        print("隨機整數：" + Random.Range(1,3));


        // 錯誤：非靜態不能透過類別存取
        // print(GameObject.layer);

        // 靜態屬性與非靜態屬性區別
        // 靜態屬性 不需要新增欄位
        // 非靜態屬性 需要新增欄位




        // 非靜態 屬性
        // 物件名稱.非靜態屬性
        print("物件圖層：" + obj1.layer);

        // 非靜態 需要有實體物件 - 存在遊戲場景內的物件
        print("燈光顏色：" + myLight.color);

        // Vector3.one = new Vector3(1,1,1)

        tran1.localScale = Vector3.one * 5;

        Time.timeScale *= 20 ;
        kid.flipX = true ;

        print("小於1.23456 的整數：" + Mathf.Floor(1.23456f));

        ball.AddForce  ( Vector3.up * 100);


    }

    //偵測玩家輸入 - 約60FPS

    private void Update()
    {
        // 原本用法 字串
        print("玩家是否按空白鍵：" + Input.GetKey("space"));
        // 多載1 列舉
        print("玩家是否按右鍵：" + Input.GetKeyDown(KeyCode.Mouse1));

        // 非靜態方法
        // 物件名稱.非靜態方法(對應引數)
        tran1.Rotate(0, 0, 10 * Time.timeScale);
      
    }



}
