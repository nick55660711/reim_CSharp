using UnityEngine;

public class Class2_Operator : MonoBehaviour
{
    public float a = 10f;
    public float b = 3f;
    public string c = "7";
    public int d = 3;
    public int e = 99;
    public int f = 9;
    public bool g = true;
    public bool h = false;

    public int key;
    public int hp = 100;


    private void Start()
    {
        #region 數學運算子(區域名稱)
        //數學運算子：加減乘除餘 + - * / %
        print(a + b);   //13
        print(a - b);   //7
        print(a * b);   //30
        print(a / b);   //3.333333
        print(a % b);   //兩個數值相除商為整數時剩下的值 - 1

        //加法：串接字串與其他資料 - 其結果為字串
        print("分數：" + 99.9f);
        //將字串與數值串接在一起不會運算 - 其結果為字串
        print(c + d);  //73
        #endregion


        #region 比較運算子
        //比較運算子：結果為布林值 - 成立時 true，不成立時 false
        //大於、小於、大於等於、小於等於、等於、不等於
        // > < >= <= == !=
        print(e > f);
        print(e < f);
        print(e >= f);
        print(e <= f);
        print(e == f);
        print(e != f);
        #endregion

        #region 邏輯運算子
        //邏輯運算子：比較兩個布林值 - 結果為布林值
        // And： A && B AB皆為true 結果為 true 否則為 false
        print("並且：" + (g && h));
        // Or： A || B AB其中之一為true 結果為 true 否則為 false
        print("或者：" + (g || h));

        // 顛倒運算值：加在布林值前 - 反轉布林值結果
        print(!true);
        print(!false);
        #endregion
        
        
        //指定運算子 = 右邊運算完後指定給左邊
        key = key + 1;
        print("鑰匙：" + key);
        
        //後置遞增 A++ 先輸出再遞增
        key++ ; //先輸出key的值再指派新的值 (key+1) 給 key
        print("鑰匙數量：" + key++);
        
        //前置遞增 ++A 先遞增再輸出
        print("鑰匙數量：" + ++key);
        
        //後置遞減
        key--;
        //前置遞減
        --key;

        //指派運算子  += -= *= /= %=
        hp += 20; // hp = hp + 20;
        print("血量：" + hp);  //120
        hp -= 50; // hp = hp - 20;
        print("血量：" + hp);  //70

    }





}