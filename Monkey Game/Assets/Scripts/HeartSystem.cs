using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSystem : MonoBehaviour
{

    public GameObject[] hearts;
    private int life;
    private bool dead;
    public GameObject canvasObject;

    void Start()
    {
        life = hearts.Length;
    }

    void Update()
    {
        if(dead == true){
            canvasObject.SetActive(true);
        }
    }

    public void TakeDamage(int d){

        if(life>=1){

            life -= d;
            Destroy(hearts[life].gameObject);

            if(life < 1){

                dead = true;
            }

        }
    }
}
