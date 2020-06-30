using System;
// List<T> Dictionary<TK,TV> Queue<T> Stack<T>
using System.Collections.Generic;
// 系統 LinQ;
using System.Linq;
using UnityEngine;


namespace Reim.Class10
{
    public class Class10_LinQ : MonoBehaviour
    {
        public int[] numbers = { 7, 24, 31, 90, 10, 5, 6, 37, 77 };

        public List<float> atk = new List<float>() { 7, 24, 31, 90, 10, 5, 6, 37, 77 };


        public bool tt(float x)
        {
            return x <= 20;
        }


        private void Start()
        {
            //LinQ 查詢語法
            // 區域變數
            var even =
                from data in numbers  // 在陣列numbers 取得資料 data
                where (data % 2) == 0 // 條件 (資料 模2) 為0
                select data;  // 選取符合條件的資料

            foreach (var item in even)
            {
                print("所有偶數：" + item);
            }
            var odd =
               from data in numbers  // 在陣列numbers 取得資料 data
               where (data % 2) == 1 // 條件 (資料 模2) 為1
               orderby data ascending // 排序 順向 ascending 反向 descending 
               select data;  // 選取符合條件的資料

            foreach (var item in odd)
            {
                print("所有奇數：" + item);
            }

            //LinQ 方法語法
            atk.Sum();
            atk.Average();
            atk.Min();
            atk.Max();

            var a20 = atk.Where((x) => x <= 20);
            var a21 = atk.Where(tt);

            foreach (var item in a20)
            {
                print("小於20：" + item);
            }

            foreach (var item in a21)
            {
                print("小於20：" + item);
            }

       
        }


        

            
    }
}