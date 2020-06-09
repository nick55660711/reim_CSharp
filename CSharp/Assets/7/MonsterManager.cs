using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManager : MonoBehaviour
{
    [Header("怪物陣列 老鷹 青蛙 老鼠 狐狸")]
    public GameObject[] monsterS;
    public void createmonster(int index) 
    {
        Instantiate(monsterS[index], new Vector3(-10, 2, 0) , Quaternion.identity);
    }


    private void Update()
    {
        

    }

}
