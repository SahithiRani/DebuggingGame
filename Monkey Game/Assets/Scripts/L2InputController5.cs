using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2InputController5 : MonoBehaviour
{
    public string corr = "return n*(n+1)*(2*n+1)/6;";
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
