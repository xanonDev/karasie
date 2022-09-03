using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wyjdzdomenu : MonoBehaviour
{
   public void wyjdz() 
   {
    SceneManager.LoadSceneAsync("menu");
   }
}
