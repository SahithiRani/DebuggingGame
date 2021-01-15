using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2InputController1 : MonoBehaviour
{
    public string corr = "int i, a[N], a_sum, a_sum_closed;";
    public GameObject canvasObject;
    public GameObject canvasObject2;
    public GameObject canvasObject3;
    public AudioSource audiosource1;
    public AudioSource audiosource2;

    public void GetInput(string str){
        if(str == corr){
            audiosource1.Play();
            canvasObject.SetActive(true);
            canvasObject2.SetActive(false);

        }else{
            audiosource2.Play();
            canvasObject3.SetActive(true);
            
            
        }
    }
}
