
using UnityEngine;
using System.Collections; // 引用 系統 集合 APO (協同程序)


namespace Reim.Class8
{

    public class Prop : MonoBehaviour, ICanUse
    {


        public Data data;

        public void Use() 
        {
            print("使用道具：" + data.name);

            StartCoroutine(Big());

        }

        /// <summary>
        /// 協同程序方法 傳回類型為IEumverator
        /// 必須傳回時間
        /// yield return new WaitForSeconds(秒數)
        /// </summary>
        /// <returns></returns>

        private IEnumerator Big()
        {
            Transform player = FindObjectOfType<Player>().transform;


            while (player.lossyScale.x <2.5f)
            {
                player.localScale += Vector3.one * 0.1f;
                yield return new WaitForSeconds(0.05f); 
            }

            Destroy(gameObject);

        }


    }


}

