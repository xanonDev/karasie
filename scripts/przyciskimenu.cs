using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class przyciskimenu : MonoBehaviour
{
    public GameObject menuskiny;
    public GameObject skryptleveli;
    public GameObject startowawiadomosc;
    public GameObject menuskiny2;
    public void przyciskjeden()
    {
        SceneManager.LoadSceneAsync("tutorial");
    }

    public void przyciskdwa()
    {
        SceneManager.LoadSceneAsync("nowygenerator");
    }
    
    public void pokazmenu()
    {
        menuskiny.SetActive(true);
    }
    public void schowajmenu()
    {
        menuskiny.SetActive(false);
        menuskiny2.SetActive(false);
    }
    public void wyborskinazwykly()
    {
        skryptleveli.GetComponent<level>().skin = 1;
    }
    public void wyborskinabiznesman()
    {
        skryptleveli.GetComponent<level>().skin = 2;
    }
    public void wyborskinaemo()
    {
        skryptleveli.GetComponent<level>().skin = 3;
    }
    public void wyborskinaseba()
    {
        skryptleveli.GetComponent<level>().skin = 4;
    }
    public void wyborskinaanime()
    {
        skryptleveli.GetComponent<level>().skin = 5;
    }
    public void wyborskinakigurumi()
    {
        skryptleveli.GetComponent<level>().skin = 6;
    }
    public void wiadomoscwyjdz() 
    {
        startowawiadomosc.SetActive(false);
    }
    public void pokaz2menu()
    {
        menuskiny.SetActive(false);
        menuskiny2.SetActive(true);
    }
    public void wrocdo1menu()
    {
        menuskiny.SetActive(true);
        menuskiny2.SetActive(false);
    }
    public void wyborskinanagito()
    {
        if(skryptleveli.GetComponent<level>().lvl >= 3)
        {
            skryptleveli.GetComponent<level>().skin = 7;
        }
    }
    public void wyborskinazoro()
    {
        if(skryptleveli.GetComponent<level>().lvl >= 4)
        {
            skryptleveli.GetComponent<level>().skin = 8;
        }
    }
    public void wyborskinatodoroki()
    {
        if(skryptleveli.GetComponent<level>().lvl >= 5)
        {
            skryptleveli.GetComponent<level>().skin = 9;
        }
    }
    public void wyborskinaichigo()
    {
        if(skryptleveli.GetComponent<level>().lvl >= 6)
        {
            skryptleveli.GetComponent<level>().skin = 10;
        }
    }
    public void wyborskinasasuke()
    {
        if(skryptleveli.GetComponent<level>().lvl >= 7)
        {
            skryptleveli.GetComponent<level>().skin = 11;
        }
    }
    public void wyborskinadio()
    {
        if(skryptleveli.GetComponent<level>().lvl >= 8)
        {
            skryptleveli.GetComponent<level>().skin = 12;
        }
    }
}
