using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{

    public float length;
    public float width;
    public float height;



    /// <summary>
    /// 體積
    /// protected 保護：允許子類別存取禁止外部存取
    /// </summary>
    protected float volume;



    /// <summary>
    /// 取得體積
    /// virrual 虛擬 ： 允許子類別覆寫
    /// </summary>
    /// <returns> 體積 </returns>
    public virtual float GetVolume()
    {
        volume = length * width * height ;
        return volume;
    }












}
