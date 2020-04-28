﻿using UnityEngine;
using UnityEngine.UI; // 引用 Unity 介面 命名空間
using System; // 引用 系統 命名空間(系統API字串轉整數)
public class Practice1_OperatorMethod : MonoBehaviour
{   
    //儲存兩筆數字
    public string number1;
    public string number2;
    
    [Header("文字：輸出結果")]
    public Text result;
    
    /// <summary>
    /// 給第一個輸入欄位使用
    /// </summary>
    /// <param name="number">第一個欄位的數值</param> 
    
    public void InputNumber1(string number)
    {
        number1 = number;
    }

    /// <summary>
    /// 給第二個輸入欄位使用
    /// </summary>
    /// <param name="number">第二個欄位的數值</param>
    public void InputNumber2(string number)
    {
        number2 = number;

    }


    /// <summary>
    /// 加法
    /// </summary>
    public void Add()
    {
        // Int32.Prase(字串) － 將字串轉為整數
        int n1 = Int32.Parse(number1);
        int n2 = Int32.Parse(number2);

        print("加法結果：" + (n1 + n2));

        // 輸出結果.文字內容 =

        result.text = ("加法結果：" + (n1 + n2));
       



    }    
    public void Minus()
    {
        // Int32.Prase(字串) － 將字串轉為整數
        int n1 = Int32.Parse(number1);
        int n2 = Int32.Parse(number2);

        print("結果：" + (n1 - n2));

        // 輸出結果.文字內容 =

        result.text = ("結果：" + (n1 - n2));

    } 
    public void Multiply()
    {
        // Int32.Prase(字串) － 將字串轉為整數
        int n1 = Int32.Parse(number1);
        int n2 = Int32.Parse(number2);

        print("結果：" + (n1 * n2));

        // 輸出結果.文字內容 =

        result.text = ("結果：" + (n1 * n2));

    }
    public void Divide()
    {
        // Int32.Prase(字串) － 將字串轉為整數
        int n1 = Int32.Parse(number1);
        int n2 = Int32.Parse(number2);

        print("結果：" + (n1 / n2));

        // 輸出結果.文字內容 =

        result.text = ("結果：" + (n1 / n2));

    }
    public void Modulo()
    {
        // Int32.Prase(字串) － 將字串轉為整數
        int n1 = Int32.Parse(number1);
        int n2 = Int32.Parse(number2);

        print("結果：" + (n1 % n2));

        // 輸出結果.文字內容 =

        result.text = ("結果：" + (n1 % n2));

    }


    

}
