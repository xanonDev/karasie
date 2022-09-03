using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class generator : MonoBehaviour
{
    public Text komenda;
    public GameObject spawngracza1;
    public GameObject spawngracza2;
    public GameObject spawngracza3;
    public GameObject spawngowna1;
    public GameObject spawngowna2;
    public GameObject spawngowna3;
    public GameObject spawngowna4;
    public GameObject spawngowna5;
    public GameObject spawngowna6;
    public GameObject spawngowna7;
    public GameObject spawngowna8;
    public GameObject spawngowna9;
    public GameObject spawngowna10;
    public GameObject spawnsiatki1;
    public GameObject spawnsiatki2;
    public GameObject spawnsiatki3;
    public int wybranyspawn = 0;
    public int wybranyspawngowna = 0;
    public int ilesiatek = 0;
    public int wybranyspawnsiatki = 0;
    public int drugispawnsiatki = 0;

    public void generujgracza()
    {
        if(komenda.text == "spawn") {
            wybranyspawn = Random.Range(1,3);
            if(wybranyspawn == 1){
                spawngracza1.GetComponent<SpriteRenderer>().enabled = true;
                spawngracza1.GetComponent<BoxCollider2D>().enabled = true;
                spawngracza1.GetComponent<playermove>().enabled = true;
                Destroy(spawngracza2);
                Destroy(spawngracza3);
            }else {
                if(wybranyspawn == 2) {
                spawngracza2.GetComponent<SpriteRenderer>().enabled = true;
                spawngracza2.GetComponent<BoxCollider2D>().enabled = true;
                spawngracza2.GetComponent<playermove>().enabled = true;
                Destroy(spawngracza1);
                Destroy(spawngracza3);
                }else {
                    if(wybranyspawn == 3) {
                spawngracza3.GetComponent<SpriteRenderer>().enabled = true;
                spawngracza3.GetComponent<BoxCollider2D>().enabled = true;
                spawngracza3.GetComponent<playermove>().enabled = true;
                Destroy(spawngracza1);
                Destroy(spawngracza2);
                    }
                }
            }
        }
    }
    public void generujgowno()
    {
        if(komenda.text == "spawn") {
        wybranyspawngowna = Random.Range(1,10);
        if(wybranyspawngowna == 1) {
            spawngowna1.GetComponent<SpriteRenderer>().enabled = true;
            spawngowna1.GetComponent<BoxCollider2D>().enabled = true;
            Destroy(spawngowna2);
            Destroy(spawngowna3);
            Destroy(spawngowna4);
            Destroy(spawngowna5);
            Destroy(spawngowna6);
            Destroy(spawngowna7);
            Destroy(spawngowna8);
            Destroy(spawngowna9);
            Destroy(spawngowna10);
        }else {
            if(wybranyspawngowna == 2) {
            spawngowna2.GetComponent<SpriteRenderer>().enabled = true;
            spawngowna2.GetComponent<BoxCollider2D>().enabled = true;
            Destroy(spawngowna3);
            Destroy(spawngowna1);
            Destroy(spawngowna4);
            Destroy(spawngowna5);
            Destroy(spawngowna6);
            Destroy(spawngowna7);
            Destroy(spawngowna8);
            Destroy(spawngowna9);
            Destroy(spawngowna10);
            }else {
                if(wybranyspawngowna == 3) {
            spawngowna3.GetComponent<SpriteRenderer>().enabled = true;
            spawngowna3.GetComponent<BoxCollider2D>().enabled = true;
            Destroy(spawngowna2);
            Destroy(spawngowna1);
            Destroy(spawngowna4);
            Destroy(spawngowna5);
            Destroy(spawngowna6);
            Destroy(spawngowna7);
            Destroy(spawngowna8);
            Destroy(spawngowna9);
            Destroy(spawngowna10);
                }else {
                    if(wybranyspawngowna == 4) {
            spawngowna4.GetComponent<SpriteRenderer>().enabled = true;
            spawngowna4.GetComponent<BoxCollider2D>().enabled = true;
            Destroy(spawngowna2);
            Destroy(spawngowna1);
            Destroy(spawngowna3);
            Destroy(spawngowna5);
            Destroy(spawngowna6);
            Destroy(spawngowna7);
            Destroy(spawngowna8);
            Destroy(spawngowna9);
            Destroy(spawngowna10);
                    }else {
                        if(wybranyspawngowna == 5) {
            spawngowna5.GetComponent<SpriteRenderer>().enabled = true;
            spawngowna5.GetComponent<BoxCollider2D>().enabled = true;
            Destroy(spawngowna2);
            Destroy(spawngowna1);
            Destroy(spawngowna3);
            Destroy(spawngowna4);
            Destroy(spawngowna6);
            Destroy(spawngowna7);
            Destroy(spawngowna8);
            Destroy(spawngowna9);
            Destroy(spawngowna10);
                        }else {
                            if(wybranyspawngowna == 6) {
            spawngowna6.GetComponent<SpriteRenderer>().enabled = true;
            spawngowna6.GetComponent<BoxCollider2D>().enabled = true;
            Destroy(spawngowna2);
            Destroy(spawngowna1);
            Destroy(spawngowna3);
            Destroy(spawngowna4);
            Destroy(spawngowna5);
            Destroy(spawngowna7);
            Destroy(spawngowna8);
            Destroy(spawngowna9);
            Destroy(spawngowna10);
                            } else {
                                if(wybranyspawngowna == 7) {
            spawngowna7.GetComponent<SpriteRenderer>().enabled = true;
            spawngowna7.GetComponent<BoxCollider2D>().enabled = true;
            Destroy(spawngowna2);
            Destroy(spawngowna1);
            Destroy(spawngowna3);
            Destroy(spawngowna4);
            Destroy(spawngowna5);
            Destroy(spawngowna6);
            Destroy(spawngowna8);
            Destroy(spawngowna9);
            Destroy(spawngowna10);
                                }else {
                                    if(wybranyspawngowna == 8) {
            spawngowna8.GetComponent<SpriteRenderer>().enabled = true;
            spawngowna8.GetComponent<BoxCollider2D>().enabled = true;
            Destroy(spawngowna2);
            Destroy(spawngowna1);
            Destroy(spawngowna3);
            Destroy(spawngowna4);
            Destroy(spawngowna5);
            Destroy(spawngowna6);
            Destroy(spawngowna7);
            Destroy(spawngowna9);
            Destroy(spawngowna10);
                                    } else {
                                        if(wybranyspawngowna == 9) {
            spawngowna9.GetComponent<SpriteRenderer>().enabled = true;
            spawngowna9.GetComponent<BoxCollider2D>().enabled = true;
            Destroy(spawngowna2);
            Destroy(spawngowna1);
            Destroy(spawngowna3);
            Destroy(spawngowna4);
            Destroy(spawngowna5);
            Destroy(spawngowna6);
            Destroy(spawngowna7);
            Destroy(spawngowna8);
            Destroy(spawngowna10);
                                        }else {
                                           if(wybranyspawngowna == 10) {
            spawngowna10.GetComponent<SpriteRenderer>().enabled = true;
            spawngowna10.GetComponent<BoxCollider2D>().enabled = true;
            Destroy(spawngowna2);
            Destroy(spawngowna1);
            Destroy(spawngowna3);
            Destroy(spawngowna4);
            Destroy(spawngowna5);
            Destroy(spawngowna6);
            Destroy(spawngowna7);
            Destroy(spawngowna8);
            Destroy(spawngowna9);
                                           } 
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        }
    }
    public void resetswiata()
    {
        if(komenda.text == "reset") {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
    public void generujsiatki()
    {
        if(komenda.text == "spawn") {
            ilesiatek = Random.Range(1,2);
            wybranyspawnsiatki = Random.Range(1,3);
            drugispawnsiatki = Random.Range(1,3);
            if(ilesiatek == 1)
            {
                if(wybranyspawnsiatki == 1) {
                    spawnsiatki1.GetComponent<SpriteRenderer>().enabled = true;
                    spawnsiatki1.GetComponent<BoxCollider2D>().enabled = true;
                    Destroy(spawnsiatki2);
                    Destroy(spawnsiatki3);
                }else {
                    if(wybranyspawnsiatki == 2) {
                    spawnsiatki2.GetComponent<SpriteRenderer>().enabled = true;
                    spawnsiatki2.GetComponent<BoxCollider2D>().enabled = true;
                    Destroy(spawnsiatki1);
                    Destroy(spawnsiatki3);
                    }else {
                        if(wybranyspawnsiatki == 3) {
                    spawnsiatki3.GetComponent<SpriteRenderer>().enabled = true;
                    spawnsiatki3.GetComponent<BoxCollider2D>().enabled = true;
                    Destroy(spawnsiatki1);
                    Destroy(spawnsiatki2);
                        }
                    }
                }
            }else {
                if(wybranyspawn == drugispawnsiatki) {
                    if(wybranyspawnsiatki == 1) {
                    spawnsiatki1.GetComponent<SpriteRenderer>().enabled = true;
                    spawnsiatki1.GetComponent<BoxCollider2D>().enabled = true;
                    Destroy(spawnsiatki2);
                    Destroy(spawnsiatki3);
                }else {
                    if(wybranyspawnsiatki == 2) {
                    spawnsiatki2.GetComponent<SpriteRenderer>().enabled = true;
                    spawnsiatki2.GetComponent<BoxCollider2D>().enabled = true;
                    Destroy(spawnsiatki1);
                    Destroy(spawnsiatki3);
                    }else {
                        if(wybranyspawnsiatki == 3) {
                    spawnsiatki3.GetComponent<SpriteRenderer>().enabled = true;
                    spawnsiatki3.GetComponent<BoxCollider2D>().enabled = true;
                    Destroy(spawnsiatki1);
                    Destroy(spawnsiatki2);
                        }
                    }
                }
                }else {
                    if((wybranyspawnsiatki == 1 && drugispawnsiatki == 2) || (wybranyspawnsiatki == 2 && drugispawnsiatki == 1)){
                    spawnsiatki1.GetComponent<SpriteRenderer>().enabled = true;
                    spawnsiatki1.GetComponent<BoxCollider2D>().enabled = true;
                    spawnsiatki2.GetComponent<SpriteRenderer>().enabled = true;
                    spawnsiatki2.GetComponent<BoxCollider2D>().enabled = true;
                    Destroy(spawnsiatki3);
                    }else {
                    if((wybranyspawnsiatki == 1 && drugispawnsiatki == 3) || (wybranyspawnsiatki == 3 && drugispawnsiatki == 1)){
                    spawnsiatki1.GetComponent<SpriteRenderer>().enabled = true;
                    spawnsiatki1.GetComponent<BoxCollider2D>().enabled = true;
                    spawnsiatki3.GetComponent<SpriteRenderer>().enabled = true;
                    spawnsiatki3.GetComponent<BoxCollider2D>().enabled = true;
                    Destroy(spawnsiatki2);
                    }else {
                    if((wybranyspawnsiatki == 2 && drugispawnsiatki == 3) || (wybranyspawnsiatki == 3 && drugispawnsiatki == 2)){
                    spawnsiatki2.GetComponent<SpriteRenderer>().enabled = true;
                    spawnsiatki2.GetComponent<BoxCollider2D>().enabled = true;
                    spawnsiatki3.GetComponent<SpriteRenderer>().enabled = true;
                    spawnsiatki3.GetComponent<BoxCollider2D>().enabled = true;
                    Destroy(spawnsiatki1);
                    }
                    }
                    }
                }
            }
        }
    }
    public void generujswiat()
    {
        resetswiata();
        generujgracza();
        generujgowno();
        generujsiatki();
    }
}
