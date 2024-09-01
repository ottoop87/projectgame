using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exitpanel : MonoBehaviour
{
   public void BackMain(){

     SceneManager.LoadSceneAsync(0);

   }

   public void Quitgame(){
    Application.Quit();
   }

   public void Start(){
    SceneManager.LoadSceneAsync(4);
   }

   public void story2(){
    SceneManager.LoadSceneAsync(5);
   }
}
