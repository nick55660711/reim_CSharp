
using System;
using UnityEngine;


namespace Reim.Class9
{
    public class Dad : MonoBehaviour
    {
        //訂閱者：訂閱事件

        public Boy boy;

        private void Start()
        {
            // 1.訂閱事件
            boy.onNoMoney += HitBoy;
            boy.onNoMoney += GiveMoney;
        }

        private void HitBoy()
        {
            print("死小孩");
        }


        // 2.實踐方法

        private void GiveMoney()
        {

            boy.money += 10;
            print("十塊拿去啦");

        }


    }
}
