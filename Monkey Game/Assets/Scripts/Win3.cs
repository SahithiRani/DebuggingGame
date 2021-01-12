﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win3 : MonoBehaviour
{
    public void PlayAgain () {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }

   public void MainMenu () {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
   }

   public void NextLevel () {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
}
