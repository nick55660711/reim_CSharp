using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 三角形 繼承 形狀
/// 三角形體積需覆寫
/// </summary>


public class Triangle : Shape
{
    public override float GetVolume()
    {
        volume = length * width * height/2; // 三角形體積
        return volume;
    }

    private void Start()
    {
        print(gameObject + "體積：" + GetVolume());
    }





}
