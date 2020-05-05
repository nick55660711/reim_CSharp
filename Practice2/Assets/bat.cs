using UnityEngine;
using UnityEngine.UI;
public class bat : MonoBehaviour
{
    [Header("bat血量"), Range(0, 200)]
    public int batHP=100;
    [Header("bat攻擊力")]
    public int batATK=30;
    [Header("bat回復量")]
    public int batCure=15;

    public Text Result;

    public slime slime1;
    public void batHit()
    {
        slime1.slimeDamage(batATK);
    }
    public void batDamage(int slimeATK)
    {
        batHP -= slimeATK;

        Result.text = gameObject.name + "－受到傷害" + slimeATK + "\n" + gameObject.name + "－當前血量" + batHP;
        
    }
    public void batRecovery()
    {
        batHP += batCure;

        Result.text = gameObject.name + "－回復" + batCure + "\n" + gameObject.name + "－當前血量" + batHP;


    }





}
