﻿
using UnityEngine;




namespace Reim.Class8
{


    public class Player : MonoBehaviour
    {
        public Transform hand;


        private void OnTriggerEnter(Collider other)
        {
            // 不使用介面
            // if (other.name == "道具 " || other.name == "武器 ") Hit();

            // 使用介面
            if (other.GetComponent<ICanUse>() != null) Hit(other.GetComponent<ICanUse>());


        }

        private void Hit(ICanUse use)
        {

            print("碰到東西了！");
            use.Use();

        }













    }
}
