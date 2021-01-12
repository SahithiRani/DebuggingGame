using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2InputController3 : MonoBehaviour
{
    public string corr = "for (i = 1; i <= N; i++)";
    public GameObject canvasObject;
    public GameObject canvasObject2;
    public GameObject canvasObject3;
    
    public void GetInput(string str){
        if(str == corr){
            
            canvasObject.SetActive(true);
            canvasObject2.SetActive(false);

        }else{
            canvasObject3.SetActive(true);
            
            
        }
    }
}
