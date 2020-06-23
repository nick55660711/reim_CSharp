using UnityEngine;


namespace Reim.Class8
{

    public class Weapon : MonoBehaviour , ICanUse
    {

        public Data data;

        public void Use()
        {
            print("使用道具：" + data.name);
            transform.SetParent(FindObjectOfType<Player>().hand);
            transform.localEulerAngles = new Vector3(0, 0, 45);
            transform.localPosition = Vector3.zero;
            GetComponent<Collider>().enabled = false;

        }
      
    }

}


