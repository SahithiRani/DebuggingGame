﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L3InputController1 : MonoBehaviour
{
    public string corr = "int SumDigit(int );";
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
