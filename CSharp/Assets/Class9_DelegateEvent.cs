using UnityEngine;

public class Class9_DelegateEvent : MonoBehaviour
{
    public void AddTen(int number)
    {
        int n = number += 10;
        print("數字累加 10：" + n);
        print("No" + number);
    }

    public int number1 = 1;


    private void Awake()
    {
        AddTen(9);
        AddTen(number1);
    }

    public void MethodA()
    {
        print("我是方法A");

    }
    public void MethodB()
    {
        print("我是方法B");

    }
    
    public void MethodC(string msg)
    {
        print("我是方法C - " + msg);

    }

    // 定義委派
    // 可以儲存 無傳回、無參數 的任何方法

    public delegate void DelegateTest();
    // 可以儲存 無傳回、一字串參數 的任何方法
    public delegate void DelegateTest2(string s);



    //  無傳回、一整數參數 
    public delegate void DelegateTest3(int n);

    // 定義委派欄位

    public DelegateTest dA;
    public DelegateTest dB;
    public DelegateTest dC;
    public DelegateTest d;
    public DelegateTest2 d2C;
    public DelegateTest3 d3;

    private void Start()
    {
        dA = MethodA; // dA 欄位儲存 方法A
        dA(); //呼叫dA
        dB = MethodB;
        dB();

        d2C = MethodC;

        d2C("未幻");
        d = MethodA;
        d += MethodB;
        d += MethodB;

        // Lambda 匿名函式
        // () => {陳述式}
        d += () =>  print("匿名"); ;

        d();


        d3 = (n) => { n *= 10;  print("n = " + n); };

        d3(7);


    }



}
