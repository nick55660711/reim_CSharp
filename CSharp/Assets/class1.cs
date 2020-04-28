using UnityEngine; // 引用Unity API(函式庫:Unity)
//類別 "class" 定義一個物件
//語法：class 類別名稱
//: MonoBehaviour 可以將此腳本掛在unity物件上
public class Class1 : MonoBehaviour
{
    //定義類別成員
    //C#
    //1.大小寫視為不同 2.括號成對出現 () [] {} '' "" <>

     [Header("car1")]
            public car car1;
     [Header("car2")]
       public car car2;
        

    //事件:在特定時間會以指定次數執行的方法(名稱為藍色)
    //開始事件:播放遊戲時執行一次 - 初始設定(Start)
    private void Start()
    { 
        
        //輸出訊息("文字訊息");
        // C# 以分號結尾;
        print("hello,world");


        //取得 get
        print("car1 CC數" + car1.cc); print("car2品牌" + car2.brand);
        
        //設定 set
        car1.weight = 999.9f;
        car1.brake = true;
        car1.brand= "toyota";
        car1.cc = 9999;
    }
}
