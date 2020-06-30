
using UnityEngine;


namespace Reim.Class10
{

    public class Class10_GenericCollectionLinQ : MonoBehaviour
    {
        public CharacterFloat cF = new CharacterFloat(100.5f, 50.9f, 10.3f);
        public CharacterInt cI;
        public Character<float> c1 = new Character<float>(99.9f , 99.9f , 9.9f);  //使用泛型：給予浮點數
        public Character<int> c2 = new Character<int>(1000 , 1000 , 50);  //使用泛型：給予整數
      




    }

    // 假設系統需要角色類別：
    public class CharacterFloat
    {
        public float hp;
        public float mp;
        public float exp;
        public CharacterFloat(float h, float m, float a)
        {
            hp = h;
            mp = m;
            exp = a;
        }

    }
    public class CharacterInt
    {
        // 多個游標：Alt + Shift + > 
        public int hp;
        public int mp;
        public int exp;

    }


    // 使用泛型 T 泛型
    public class Character<T>
    {
        public T hp; //欄位的類型為泛型
        public T mp;
        public T exp;
        public Character(T h,T m , T a)
        {
            hp = h;
            mp = m;
            exp = a;
        }
    }

}








