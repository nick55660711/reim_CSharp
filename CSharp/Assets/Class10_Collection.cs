using UnityEngine;
// List - 泛型
using System.Collections.Generic;
// ArrayList
using System.Collections;
namespace Reim.Class10
{

    public class Class10_Collection : MonoBehaviour
    {
        #region ArrayList、List
        //陣列：一旦固定長度就不能改變
        public int[] scores = { 100, 90, 80, 70, 60 };

        // 集合：彈性
        //清單
        public List<float> hp = new List<float> { 99.9f, 88.8f, 77.7f };
        public List<float> hpResult = new List<float>();
        public ArrayList numbers = new ArrayList();

        public List<int> count = new List<int> { 9, 100, 15, 77, 30, 999, 123 };
        private void Start()
        {
            // 1.集合可以改變長度

            hp.Add(66.6f); //清單.增加<T>
            hp.Remove(88.8f); //清單.刪除<T>
            print("是否包含66.6：" + hp.Contains(66.6f)); // hp.Contains(T) 是否包含T：回傳bool

            hpResult = hp.FindAll((x) => x >= 70f); // 搜尋所有(大於等於70)資料

            // ArrayList與List差異
            // ArrayList 為 Object型別：可存放所有類型
            // List為泛型：一旦指定類型就只能存放該類型
            // ArrayList不會顯示在屬性面板
            numbers.Add(100);
            numbers.Add(77.7f);
            numbers.Add("Reim");
            numbers.Add(0 == 0);

            count.Sort(); //由小到大排序
            count.Reverse(); // 反轉










        }
        #endregion
        #region 佇列與堆疊
        // 佇列：
        // 1.添加資料到尾端
        // 先進先出
        //

        public Queue<int> lv = new Queue<int>();
        public Queue<string> people = new Queue<string>();
        // 堆疊
        // 2. 添加資料至頂端
        // 後發先至
        public Stack<int> n = new Stack<int>();
        public Stack<string> Box = new Stack<string>();

        private void Awake()
        {
            lv.Enqueue(10); // 添加佇列資料至結尾
            lv.Enqueue(20);
            lv.Enqueue(30);




            foreach (var item in lv)
            {
                print("佇列的資料：" + item);

            }



            n.Push(10);  // 添加堆疊資料至開頭 (後發先至)
            n.Push(20);
            n.Push(30);

            foreach (var item in n)
            {
                print("堆疊的資料：" + item);

            }

            people.Enqueue("Reim");
            people.Enqueue("Mokou");
            people.Enqueue("Kagu");

            Box.Push("盒子1");
            Box.Push("盒子2");
            Box.Push("盒子3");
        }


        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1)) print("排隊的第一個人：" + people.Dequeue()); //Dequeue 取得第一筆資料後從佇列移除 Peek 取得第一筆資料而保留
            if (Input.GetKeyDown(KeyCode.Alpha2)) print("堆放的盒子：" + Box.Pop()); //Pop 取得第一筆資料後從堆疊移除
        }
        #endregion
        #region 雜湊表、字典
        //兩個關鍵字
        // Key、Value - 關鍵字、值

            //差異：
            //雜湊表：物件
            //字典：泛型

            //雜湊表
        public Hashtable player = new Hashtable();

        // 字典 - 關鍵字(字串)，值(整數)
        public Dictionary<string, int> data = new Dictionary<string, int>();


        //物件啟動時執行事件
        private void OnEnable()
        {
            player.Add("Lv", 99);
            player.Add("Hp", 500);
            player.Add("Mp", 123);
            player.Add(true, true);

            // DictionvaryEntry 結構 - 儲存 Key與 Value
            foreach (DictionaryEntry item in player)
            {
                print("雜湊表資料 Key:" + item.Key);
                print("雜湊表資料 Value:" + item.Value);
            }

            data.Add("短刀", 30);
            data.Add("長刀", 300);
            data.Add("屠龍刀", 30000);

            foreach (var item in data)
            {
                print("字典資料變數 Key:" + item.Key);
                print("字典資料 Key:" + data.Keys);
                print("字典資料變數 Value:" + item.Value);
                print("字典資料 Value:" + data.Values);
            }
            
            foreach (KeyValuePair<string,int> item in data)
            {
                print("字典資料變數 Key:" + item.Key);
                print("字典資料 Key:" + data.Keys);
                print("字典資料變數 Value:" + item.Value);
                print("字典資料 Value:" + data.Values);
            }
            print("屠龍刀價格：" + data["屠龍刀"]);
            print("等級：" + player["Lv"]);




        }



        #endregion




    }
}
