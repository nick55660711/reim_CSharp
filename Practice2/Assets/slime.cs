using UnityEngine;
using UnityEngine.UI;
public class slime : MonoBehaviour
{
    [Header("slime血量"), Range(0, 150)]
    public int slimeHP = 40;
    [Header("slime攻擊力")]
    public int slimeATK = 10;
    [Header("slime回復量")]
    public int slimeCure = 25;

    public Text Result;

    public bat bat1;
    public void slimeHit()
    {
        bat1.batDamage(slimeATK);


    }
    public void slimeDamage(int batATK)
    {
       
        slimeHP -= batATK;

        Result.text = gameObject.name + "－受到傷害" + bat1.batATK + "\n" + gameObject.name + "－當前血量" + slimeHP;

        
    }
    public void slimeRecovery()
    {
        slimeHP += slimeCure;
        
        Result.text = gameObject.name + "－回復" + slimeCure + "\n" + gameObject.name + "－當前血量" + slimeHP;


    }
}
