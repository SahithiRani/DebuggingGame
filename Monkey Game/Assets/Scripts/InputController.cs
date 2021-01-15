using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public string corr = "scanf("+'\u0022'+"%lf %lf"+'\u0022'+", &a, &b);";
    public GameObject canvasObject;
    public GameObject canvasObject2;
    public GameObject canvasObject3;
    public AudioSource audioSource1;
    public AudioSource audioSource2;

    public void GetInput(string str){
        if(str == corr){

            audioSource1.Play();
            canvasObject.SetActive(true);
            canvasObject2.SetActive(false);

        }else{
            canvasObject3.SetActive(true);
            audioSource2.Play();
            
        }
    }
}
