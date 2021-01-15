using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController2 : MonoBehaviour
{
    public string corr = "product = a * b;";
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
