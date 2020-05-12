using UnityEngine;

public class camera : MonoBehaviour
{
    [Range(0f, 1f)] public float Speed;



    void Update()
    {



        
            {

                transform.Translate(Speed * Input.GetAxis("Horizontal"), 0f, 0f);
                transform.Translate(0f, Speed * Input.GetAxis("Vertical"), 0f);
                transform.Translate(0f, 0f, Speed * -Input.GetAxis("Jump"));

            }
        }



    }

