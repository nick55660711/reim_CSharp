﻿
using UnityEngine;


namespace Reim.Class9
{
    public class Mom : MonoBehaviour
    {
        //訂閱者：訂閱事件

        public Boy boy;

        private void Start()
        {
            // 1.訂閱事件
            boy.onNoMoney += GiveMoney;
        }


        // 2.實踐方法

        private void GiveMoney()
        {

            print("這麼快就花完啦");
            boy.money += 100;

        }


    }
}
