using UnityEngine;

public class Class3_Method : MonoBehaviour
{
    // 儲存帶有 Person 類別的物件
    public Person person1;
    public Person person2;
    private void Start()
    {


        // 呼叫物件  person1   方法 Talk
        person1.Talk();
        person2.Talk();
        // 傳回方法可以直接當作傳回類型使用
        print("kid BMI" + person1.BMI());
        print("police BMI" + person2.BMI());
        // 使用有參數的方法必須填入對應的引數
        //指定選填式參數  【選填式參數名稱: 值】
        person1.Walk(99, sound:"摳摳摳");
        person2.Walk(10, "左邊", equip:"槍");

        person1.Attack();
        person2.Attack("SP12");
        
    }
}
