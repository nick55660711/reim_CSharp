using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class8_StructInterface : MonoBehaviour
{
    // Unity 定義的結構 struct

    public Vector3 pos;


    // 使用結構
    public Direction myDire1;

    // new 新增物件，並可以使用建構子
    public Direction myDire2 = new Direction(4);



    private void Start()
    {
        // 使用結構成員
        // 三維向量結構 方法成員
        pos.Set(1, 2, 3);
        // 三維向量結構 欄位成員
        print("X座標" + pos.x);


        // 指定結構成員
        myDire1.direction = 1;


        // 結構與靜態取得指令是一樣的
        print("方向右邊的值" + Direction.right);

        // 錯誤：不能變更常數
        // Direction.left = 5;

        myDire1.Set("左");
        print("方向：" + myDire1.direction);


        // 透過new新增的方向資訊
        print("第二筆方向資訊：" + myDire2.direction);


    }


    // 類別一定要使用 new 新增物件
    // 結構可用可不用
    public Class_Data c_data1 = new Class_Data();
    public Struct_Data s_data1;


    // 類別：參考型別 － 傳址
    public Class_Data c2 = new Class_Data("Kagu",100,15);
    public Class_Data c3 = new Class_Data("Erin",400,25);
    public Struct_Data s2 = new Struct_Data("Kagu", 100, 15);
    public Struct_Data s3 = new Struct_Data("Erin", 400, 25);

    // 結構：實值型別 － 傳值

    private void Awake()
    {
        c_data1.name = "Reim";
        print(c_data1.name); 
        
        
        s_data1.name = "Moko";
        print(s_data1.name);

        c2 = c3; // c2 = c3 兩筆資料地址相同
        c2.name = "Kagu"; // 修改c2等同於修改c3

        s2 = s3;
        s2.name= "Kagu";

    }




}
