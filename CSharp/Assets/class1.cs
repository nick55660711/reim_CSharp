using UnityEngine; // 引用Unity API(函式庫:Unity)
//類別 class 定義一個物件
//語法：class 類別名稱
//: MonoBehaviour 可以將此腳本掛在unity物件上
public class class1 : MonoBehaviour
{
    //定義類別成員
    //C#
    //1.大小寫視為不同 2.括號成對出現 () [] {} '' "" <>

    //事件:在特定時間會以指定次數執行的方法(名稱為藍色)
    //開始事件:播放遊戲時執行一次 - 初始設定(Start)
    private void Start()
    { 
        
        //輸出訊息("文字訊息");
        // C# 以分號結尾;
        print("hello,world");
    }
}
