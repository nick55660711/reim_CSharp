using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lam : MonoBehaviour
{
    public delegate bool DelegateTest3(int n);
    public delegate void DelegateTest2(int n);
    public DelegateTest2 d2;
    public DelegateTest3 d3;

    void Start()
    {
        d2 = (x) => { x *= 10; };
        d3 = (x) => { return x >= 10; };
        print(d3(52));
    }

}
