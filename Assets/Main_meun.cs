using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Main_meun : MonoBehaviour
{
   public void BackMain(){

     SceneManager.LoadSceneAsync(0);

   }

   public void Quitgame(){
    
    Application.Quit();

   }
}
