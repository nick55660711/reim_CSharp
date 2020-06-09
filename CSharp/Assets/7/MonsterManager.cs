using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene("第七章：練習");

        }

    }

}
