using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class house : MonoBehaviour
{

    [Header("血量"),Range(100,10000)]
    public float hp;
    [Header("血條")]
    public Image hpBar;
    public GameObject EXP;

    private float hpMax;

    public void Damage(float damage)
    {
        hp -= damage;
        hpBar.fillAmount = hp / hpMax;
       
        if (hp <= 0)
        {
            Instantiate(EXP, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

    }






    private void Awake()
    {
        hpMax = hp;
    }






}
