using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nowygenerator : MonoBehaviour
{
    public Text komenda;
    public GameObject gracz;
    public GameObject gowno;
    public GameObject siatka;
    public GameObject haczyk;
    public GameObject szczupak;
    public GameObject miejscespawnu1;
    public GameObject miejscespawnu2;
    public GameObject miejscespawnu3;
    public GameObject miejscespawnu4;
    public GameObject miejscespawnu5;
    public GameObject miejscespawnu6;
    public GameObject miejscespawnu7;
    public GameObject miejscespawnu8;
    public GameObject miejscespawnu9;
    public GameObject miejscespawnu10;
    public GameObject miejscespawnu11;
    public GameObject miejscespawnu12;
    public GameObject miejscespawnu13;
    public GameObject miejscespawnu14;
    public GameObject miejscespawnu15;
    public GameObject miejscespawnu16;
    public GameObject miejscespawnu17;
    public GameObject miejscespawnu18;
    public GameObject miejscespawnu19;
    public GameObject miejscespawnu20;
    public GameObject miejscespawnu21;
    public GameObject miejscespawnu22;
    public GameObject miejscespawnu23;
    public GameObject miejscespawnu24;
    public GameObject miejscespawnu25;
    public GameObject miejscespawnu26;
    public GameObject miejscespawnu27;
    public GameObject miejscespawnu28;
    public GameObject miejscespawnu29;
    public int spawngracza;
    public int spawngowna;
    public int pulapka;
    public void generujmiejscegraczaigowna()
    {
        if(komenda.text == "spawn")
        {
            spawngracza = Random.Range(1,29);
            spawngowna = Random.Range(1,29);
            while(spawngracza == spawngowna)
            {
            spawngracza = Random.Range(1,29);
            spawngowna = Random.Range(1,29);
            }
        }
    }
    public void przywolajgracza()
    {
        if(spawngracza == 1) {
            gracz.transform.position = new Vector3(miejscespawnu1.transform.position.x, miejscespawnu1.transform.position.y, miejscespawnu1.transform.position.z);
            Destroy(miejscespawnu1);
        }else {
            if(spawngracza == 2) {
            gracz.transform.position = new Vector3(miejscespawnu2.transform.position.x, miejscespawnu2.transform.position.y, miejscespawnu2.transform.position.z);
            Destroy(miejscespawnu2);
        }else {
            if(spawngracza == 3) {
            gracz.transform.position = new Vector3(miejscespawnu3.transform.position.x, miejscespawnu3.transform.position.y, miejscespawnu3.transform.position.z);
            Destroy(miejscespawnu3);
        }else {
            if(spawngracza == 4) {
            gracz.transform.position = new Vector3(miejscespawnu4.transform.position.x, miejscespawnu4.transform.position.y, miejscespawnu4.transform.position.z);
            Destroy(miejscespawnu4);
        }else {
            if(spawngracza == 5) {
            gracz.transform.position = new Vector3(miejscespawnu5.transform.position.x, miejscespawnu5.transform.position.y, miejscespawnu5.transform.position.z);
            Destroy(miejscespawnu5);
        }else {
            if(spawngracza == 6) {
            gracz.transform.position = new Vector3(miejscespawnu6.transform.position.x, miejscespawnu6.transform.position.y, miejscespawnu6.transform.position.z);
            Destroy(miejscespawnu6);
        }else {
            if(spawngracza == 7) {
            gracz.transform.position = new Vector3(miejscespawnu7.transform.position.x, miejscespawnu7.transform.position.y, miejscespawnu7.transform.position.z);
            Destroy(miejscespawnu7);
        }else {
            if(spawngracza == 8) {
            gracz.transform.position = new Vector3(miejscespawnu8.transform.position.x, miejscespawnu8.transform.position.y, miejscespawnu8.transform.position.z);
            Destroy(miejscespawnu8);
        }else {
            if(spawngracza == 9) {
            gracz.transform.position = new Vector3(miejscespawnu9.transform.position.x, miejscespawnu9.transform.position.y, miejscespawnu9.transform.position.z);
            Destroy(miejscespawnu9);
        }else {
            if(spawngracza == 10) {
            gracz.transform.position = new Vector3(miejscespawnu10.transform.position.x, miejscespawnu10.transform.position.y, miejscespawnu10.transform.position.z);
            Destroy(miejscespawnu10);
        }else {
             if(spawngracza == 11) {
            gracz.transform.position = new Vector3(miejscespawnu11.transform.position.x, miejscespawnu11.transform.position.y, miejscespawnu11.transform.position.z);
            Destroy(miejscespawnu11);
        }else {
             if(spawngracza == 12) {
            gracz.transform.position = new Vector3(miejscespawnu12.transform.position.x, miejscespawnu12.transform.position.y, miejscespawnu12.transform.position.z);
            Destroy(miejscespawnu12);
        }else {
             if(spawngracza == 13) {
            gracz.transform.position = new Vector3(miejscespawnu13.transform.position.x, miejscespawnu13.transform.position.y, miejscespawnu13.transform.position.z);
            Destroy(miejscespawnu13);
        }else {
             if(spawngracza == 14) {
            gracz.transform.position = new Vector3(miejscespawnu14.transform.position.x, miejscespawnu14.transform.position.y, miejscespawnu14.transform.position.z);
            Destroy(miejscespawnu14);
        }else {
             if(spawngracza == 15) {
            gracz.transform.position = new Vector3(miejscespawnu15.transform.position.x, miejscespawnu15.transform.position.y, miejscespawnu15.transform.position.z);
            Destroy(miejscespawnu15);
        }else {
             if(spawngracza == 16) {
            gracz.transform.position = new Vector3(miejscespawnu16.transform.position.x, miejscespawnu16.transform.position.y, miejscespawnu16.transform.position.z);
            Destroy(miejscespawnu16);
        }else {
             if(spawngracza == 17) {
            gracz.transform.position = new Vector3(miejscespawnu17.transform.position.x, miejscespawnu17.transform.position.y, miejscespawnu17.transform.position.z);
            Destroy(miejscespawnu17);
        }else {
             if(spawngracza == 18) {
            gracz.transform.position = new Vector3(miejscespawnu18.transform.position.x, miejscespawnu18.transform.position.y, miejscespawnu18.transform.position.z);
            Destroy(miejscespawnu18);
        }else {
             if(spawngracza == 19) {
            gracz.transform.position = new Vector3(miejscespawnu19.transform.position.x, miejscespawnu19.transform.position.y, miejscespawnu19.transform.position.z);
            Destroy(miejscespawnu19);
        }else {
             if(spawngracza == 20) {
            gracz.transform.position = new Vector3(miejscespawnu20.transform.position.x, miejscespawnu20.transform.position.y, miejscespawnu20.transform.position.z);
            Destroy(miejscespawnu20);
        }else {
            if(spawngracza == 21) {
            gracz.transform.position = new Vector3(miejscespawnu21.transform.position.x, miejscespawnu21.transform.position.y, miejscespawnu21.transform.position.z);
            Destroy(miejscespawnu21);
        }else {
            if(spawngracza == 22) {
            gracz.transform.position = new Vector3(miejscespawnu22.transform.position.x, miejscespawnu22.transform.position.y, miejscespawnu22.transform.position.z);
            Destroy(miejscespawnu22);
        }else {
            if(spawngracza == 23) {
            gracz.transform.position = new Vector3(miejscespawnu23.transform.position.x, miejscespawnu23.transform.position.y, miejscespawnu23.transform.position.z);
            Destroy(miejscespawnu23);
        }else {
            if(spawngracza == 24) {
            gracz.transform.position = new Vector3(miejscespawnu24.transform.position.x, miejscespawnu24.transform.position.y, miejscespawnu24.transform.position.z);
            Destroy(miejscespawnu24);
        }else {
            if(spawngracza == 25) {
            gracz.transform.position = new Vector3(miejscespawnu25.transform.position.x, miejscespawnu25.transform.position.y, miejscespawnu25.transform.position.z);
            Destroy(miejscespawnu25);
        }else {
            if(spawngracza == 26) {
            gracz.transform.position = new Vector3(miejscespawnu26.transform.position.x, miejscespawnu26.transform.position.y, miejscespawnu26.transform.position.z);
            Destroy(miejscespawnu26);
        }else {
            if(spawngracza == 27) {
            gracz.transform.position = new Vector3(miejscespawnu27.transform.position.x, miejscespawnu27.transform.position.y, miejscespawnu27.transform.position.z);
            Destroy(miejscespawnu27);
        }else {
            if(spawngracza == 28) {
            gracz.transform.position = new Vector3(miejscespawnu28.transform.position.x, miejscespawnu28.transform.position.y, miejscespawnu28.transform.position.z);
            Destroy(miejscespawnu28);
        }else {
            if(spawngracza == 29) {
            gracz.transform.position = new Vector3(miejscespawnu29.transform.position.x, miejscespawnu29.transform.position.y, miejscespawnu29.transform.position.z);
            Destroy(miejscespawnu29);
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
        }
        }
        }
        }
        }
    }
    public void przywolajgowno()
    {
                if(spawngowna == 1) {
            gowno.transform.position = new Vector3(miejscespawnu1.transform.position.x, miejscespawnu1.transform.position.y, miejscespawnu1.transform.position.z);
            Destroy(miejscespawnu1);
        }else {
            if(spawngowna == 2) {
            gowno.transform.position = new Vector3(miejscespawnu2.transform.position.x, miejscespawnu2.transform.position.y, miejscespawnu2.transform.position.z);
            Destroy(miejscespawnu2);
        }else {
            if(spawngowna == 3) {
            gowno.transform.position = new Vector3(miejscespawnu3.transform.position.x, miejscespawnu3.transform.position.y, miejscespawnu3.transform.position.z);
            Destroy(miejscespawnu3);
        }else {
            if(spawngowna == 4) {
            gowno.transform.position = new Vector3(miejscespawnu4.transform.position.x, miejscespawnu4.transform.position.y, miejscespawnu4.transform.position.z);
            Destroy(miejscespawnu4);
        }else {
            if(spawngowna == 5) {
            gowno.transform.position = new Vector3(miejscespawnu5.transform.position.x, miejscespawnu5.transform.position.y, miejscespawnu5.transform.position.z);
            Destroy(miejscespawnu5);
        }else {
            if(spawngowna == 6) {
            gowno.transform.position = new Vector3(miejscespawnu6.transform.position.x, miejscespawnu6.transform.position.y, miejscespawnu6.transform.position.z);
            Destroy(miejscespawnu6);
        }else {
            if(spawngowna == 7) {
            gowno.transform.position = new Vector3(miejscespawnu7.transform.position.x, miejscespawnu7.transform.position.y, miejscespawnu7.transform.position.z);
            Destroy(miejscespawnu7);
        }else {
            if(spawngowna == 8) {
            gowno.transform.position = new Vector3(miejscespawnu8.transform.position.x, miejscespawnu8.transform.position.y, miejscespawnu8.transform.position.z);
            Destroy(miejscespawnu8);
        }else {
            if(spawngowna == 9) {
            gowno.transform.position = new Vector3(miejscespawnu9.transform.position.x, miejscespawnu9.transform.position.y, miejscespawnu9.transform.position.z);
            Destroy(miejscespawnu9);
        }else {
            if(spawngowna == 10) {
            gowno.transform.position = new Vector3(miejscespawnu10.transform.position.x, miejscespawnu10.transform.position.y, miejscespawnu10.transform.position.z);
            Destroy(miejscespawnu10);
        }else {
             if(spawngowna == 11) {
            gowno.transform.position = new Vector3(miejscespawnu11.transform.position.x, miejscespawnu11.transform.position.y, miejscespawnu11.transform.position.z);
            Destroy(miejscespawnu11);
        }else {
             if(spawngowna == 12) {
            gowno.transform.position = new Vector3(miejscespawnu12.transform.position.x, miejscespawnu12.transform.position.y, miejscespawnu12.transform.position.z);
            Destroy(miejscespawnu12);
        }else {
             if(spawngowna == 13) {
            gowno.transform.position = new Vector3(miejscespawnu13.transform.position.x, miejscespawnu13.transform.position.y, miejscespawnu13.transform.position.z);
            Destroy(miejscespawnu13);
        }else {
             if(spawngowna == 14) {
            gowno.transform.position = new Vector3(miejscespawnu14.transform.position.x, miejscespawnu14.transform.position.y, miejscespawnu14.transform.position.z);
            Destroy(miejscespawnu14);
        }else {
             if(spawngowna == 15) {
            gowno.transform.position = new Vector3(miejscespawnu15.transform.position.x, miejscespawnu15.transform.position.y, miejscespawnu15.transform.position.z);
            Destroy(miejscespawnu15);
        }else {
             if(spawngowna == 16) {
            gowno.transform.position = new Vector3(miejscespawnu16.transform.position.x, miejscespawnu16.transform.position.y, miejscespawnu16.transform.position.z);
            Destroy(miejscespawnu16);
        }else {
             if(spawngowna == 17) {
            gowno.transform.position = new Vector3(miejscespawnu17.transform.position.x, miejscespawnu17.transform.position.y, miejscespawnu17.transform.position.z);
            Destroy(miejscespawnu17);
        }else {
             if(spawngowna == 18) {
            gowno.transform.position = new Vector3(miejscespawnu18.transform.position.x, miejscespawnu18.transform.position.y, miejscespawnu18.transform.position.z);
            Destroy(miejscespawnu18);
        }else {
             if(spawngowna == 19) {
            gowno.transform.position = new Vector3(miejscespawnu19.transform.position.x, miejscespawnu19.transform.position.y, miejscespawnu19.transform.position.z);
            Destroy(miejscespawnu19);
        }else {
             if(spawngowna == 20) {
            gowno.transform.position = new Vector3(miejscespawnu20.transform.position.x, miejscespawnu20.transform.position.y, miejscespawnu20.transform.position.z);
            Destroy(miejscespawnu20);
        }else {
            if(spawngowna == 21) {
            gowno.transform.position = new Vector3(miejscespawnu21.transform.position.x, miejscespawnu21.transform.position.y, miejscespawnu21.transform.position.z);
            Destroy(miejscespawnu21);
        }else {
            if(spawngowna == 22) {
            gowno.transform.position = new Vector3(miejscespawnu22.transform.position.x, miejscespawnu22.transform.position.y, miejscespawnu22.transform.position.z);
            Destroy(miejscespawnu22);
        }else {
            if(spawngowna == 23) {
            gowno.transform.position = new Vector3(miejscespawnu23.transform.position.x, miejscespawnu23.transform.position.y, miejscespawnu23.transform.position.z);
            Destroy(miejscespawnu23);
        }else {
            if(spawngowna == 24) {
            gowno.transform.position = new Vector3(miejscespawnu24.transform.position.x, miejscespawnu24.transform.position.y, miejscespawnu24.transform.position.z);
            Destroy(miejscespawnu24);
        }else {
            if(spawngowna== 25) {
            gowno.transform.position = new Vector3(miejscespawnu25.transform.position.x, miejscespawnu25.transform.position.y, miejscespawnu25.transform.position.z);
            Destroy(miejscespawnu25);
        }else {
            if(spawngowna == 26) {
            gowno.transform.position = new Vector3(miejscespawnu26.transform.position.x, miejscespawnu26.transform.position.y, miejscespawnu26.transform.position.z);
            Destroy(miejscespawnu26);
        }else {
            if(spawngowna == 27) {
            gowno.transform.position = new Vector3(miejscespawnu27.transform.position.x, miejscespawnu27.transform.position.y, miejscespawnu27.transform.position.z);
            Destroy(miejscespawnu27);
        }else {
            if(spawngowna == 28) {
            gowno.transform.position = new Vector3(miejscespawnu28.transform.position.x, miejscespawnu28.transform.position.y, miejscespawnu28.transform.position.z);
            Destroy(miejscespawnu28);
        }else {
            if(spawngowna == 29) {
            gowno.transform.position = new Vector3(miejscespawnu29.transform.position.x, miejscespawnu29.transform.position.y, miejscespawnu29.transform.position.z);
            Destroy(miejscespawnu29);
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
        }
        }
        }
        }
        }
    }
    public void generujspawn1() 
    {
       pulapka = Random.Range(1,10);
       if(pulapka>5) {
        if(pulapka == 6 || pulapka == 7) {
            GameObject nowapulapka = GameObject.Instantiate(siatka);
            nowapulapka.transform.position = miejscespawnu1.transform.position;
        }else {
            if(pulapka == 8 || pulapka == 9) {
            GameObject nowapulapka = GameObject.Instantiate(szczupak);
            nowapulapka.transform.position = miejscespawnu1.transform.position;
            }else {
                if(pulapka == 10) {
            GameObject nowapulapka = GameObject.Instantiate(haczyk);
            nowapulapka.transform.position = miejscespawnu1.transform.position;
                }
            }
        }
       }
    }
    public void generujspawn2() 
    {
       pulapka = Random.Range(1,10);
       if(pulapka>5) {
        if(pulapka == 6 || pulapka == 7) {
            GameObject nowapulapka = GameObject.Instantiate(siatka);
            nowapulapka.transform.position = miejscespawnu2.transform.position;
        }else {
            if(pulapka == 8 || pulapka == 9) {
            GameObject nowapulapka = GameObject.Instantiate(szczupak);
            nowapulapka.transform.position = miejscespawnu2.transform.position;
            }else {
                if(pulapka == 10) {
            GameObject nowapulapka = GameObject.Instantiate(haczyk);
            nowapulapka.transform.position = miejscespawnu2.transform.position;
                }
            }
        }
       }
    }
    public void generujspawn3() 
    {
       pulapka = Random.Range(1,10);
       if(pulapka>5) {
        if(pulapka == 6 || pulapka == 7) {
            GameObject nowapulapka = GameObject.Instantiate(siatka);
            nowapulapka.transform.position = miejscespawnu3.transform.position;
        }else {
            if(pulapka == 8 || pulapka == 9) {
            GameObject nowapulapka = GameObject.Instantiate(szczupak);
            nowapulapka.transform.position = miejscespawnu3.transform.position;
            }else {
                if(pulapka == 10) {
            GameObject nowapulapka = GameObject.Instantiate(haczyk);
            nowapulapka.transform.position = miejscespawnu3.transform.position;
                }
            }
        }
       }
    }
    public void generujspawn4() 
    {
       pulapka = Random.Range(1,10);
       if(pulapka>5) {
        if(pulapka == 6 || pulapka == 7) {
            GameObject nowapulapka = GameObject.Instantiate(siatka);
            nowapulapka.transform.position = miejscespawnu4.transform.position;
        }else {
            if(pulapka == 8 || pulapka == 9) {
            GameObject nowapulapka = GameObject.Instantiate(szczupak);
            nowapulapka.transform.position = miejscespawnu4.transform.position;
            }else {
                if(pulapka == 10) {
            GameObject nowapulapka = GameObject.Instantiate(haczyk);
            nowapulapka.transform.position = miejscespawnu4.transform.position;
                }
            }
        }
       }
    }
    public void generujspawn5() 
    {
       pulapka = Random.Range(1,10);
       if(pulapka>5) {
        if(pulapka == 6 || pulapka == 7) {
            GameObject nowapulapka = GameObject.Instantiate(siatka);
            nowapulapka.transform.position = miejscespawnu5.transform.position;
        }else {
            if(pulapka == 8 || pulapka == 9) {
            GameObject nowapulapka = GameObject.Instantiate(szczupak);
            nowapulapka.transform.position = miejscespawnu5.transform.position;
            }else {
                if(pulapka == 10) {
            GameObject nowapulapka = GameObject.Instantiate(haczyk);
            nowapulapka.transform.position = miejscespawnu5.transform.position;
                }
            }
        }
       }
    }
    public void generujspawn6() 
    {
       pulapka = Random.Range(1,10);
       if(pulapka>5) {
        if(pulapka == 6 || pulapka == 7) {
            GameObject nowapulapka = GameObject.Instantiate(siatka);
            nowapulapka.transform.position = miejscespawnu6.transform.position;
        }else {
            if(pulapka == 8 || pulapka == 9) {
            GameObject nowapulapka = GameObject.Instantiate(szczupak);
            nowapulapka.transform.position = miejscespawnu6.transform.position;
            }else {
                if(pulapka == 10) {
            GameObject nowapulapka = GameObject.Instantiate(haczyk);
            nowapulapka.transform.position = miejscespawnu6.transform.position;
                }
            }
        }
       }
    }
    public void generujspawn7() 
    {
       pulapka = Random.Range(1,10);
       if(pulapka>5) {
        if(pulapka == 6 || pulapka == 7) {
            GameObject nowapulapka = GameObject.Instantiate(siatka);
            nowapulapka.transform.position = miejscespawnu7.transform.position;
        }else {
            if(pulapka == 8 || pulapka == 9) {
            GameObject nowapulapka = GameObject.Instantiate(szczupak);
            nowapulapka.transform.position = miejscespawnu7.transform.position;
            }else {
                if(pulapka == 10) {
            GameObject nowapulapka = GameObject.Instantiate(haczyk);
            nowapulapka.transform.position = miejscespawnu7.transform.position;
                }
            }
        }
       }
    }
    public void generujspawn8() 
    {
       pulapka = Random.Range(1,10);
       if(pulapka>5) {
        if(pulapka == 6 || pulapka == 7) {
            GameObject nowapulapka = GameObject.Instantiate(siatka);
            nowapulapka.transform.position = miejscespawnu8.transform.position;
        }else {
            if(pulapka == 8 || pulapka == 9) {
            GameObject nowapulapka = GameObject.Instantiate(szczupak);
            nowapulapka.transform.position = miejscespawnu8.transform.position;
            }else {
                if(pulapka == 10) {
            GameObject nowapulapka = GameObject.Instantiate(haczyk);
            nowapulapka.transform.position = miejscespawnu8.transform.position;
                }
            }
        }
       }
    }
    public void generujspawn9() 
    {
       pulapka = Random.Range(1,10);
       if(pulapka>5) {
        if(pulapka == 6 || pulapka == 7) {
            GameObject nowapulapka = GameObject.Instantiate(siatka);
            nowapulapka.transform.position = miejscespawnu9.transform.position;
        }else {
            if(pulapka == 8 || pulapka == 9) {
            GameObject nowapulapka = GameObject.Instantiate(szczupak);
            nowapulapka.transform.position = miejscespawnu9.transform.position;
            }else {
                if(pulapka == 10) {
            GameObject nowapulapka = GameObject.Instantiate(haczyk);
            nowapulapka.transform.position = miejscespawnu9.transform.position;
                }
            }
        }
       }
    }
    public void generujspawn10() 
    {
       pulapka = Random.Range(1,10);
       if(pulapka>5) {
        if(pulapka == 6 || pulapka == 7) {
            GameObject nowapulapka = GameObject.Instantiate(siatka);
            nowapulapka.transform.position = miejscespawnu10.transform.position;
        }else {
            if(pulapka == 8 || pulapka == 9) {
            GameObject nowapulapka = GameObject.Instantiate(szczupak);
            nowapulapka.transform.position = miejscespawnu10.transform.position;
            }else {
                if(pulapka == 10) {
            GameObject nowapulapka = GameObject.Instantiate(haczyk);
            nowapulapka.transform.position = miejscespawnu10.transform.position;
                }
            }
        }
       }
    }
    public void generujspawn11() 
    {
       pulapka = Random.Range(1,10);
       if(pulapka>5) {
        if(pulapka == 6 || pulapka == 7) {
            GameObject nowapulapka = GameObject.Instantiate(siatka);
            nowapulapka.transform.position = miejscespawnu11.transform.position;
        }else {
            if(pulapka == 8 || pulapka == 9) {
            GameObject nowapulapka = GameObject.Instantiate(szczupak);
            nowapulapka.transform.position = miejscespawnu11.transform.position;
            }else {
                if(pulapka == 10) {
            GameObject nowapulapka = GameObject.Instantiate(haczyk);
            nowapulapka.transform.position = miejscespawnu11.transform.position;
                }
            }
        }
       }
    }
    public void generujspawn12() 
    {
       pulapka = Random.Range(1,10);
       if(pulapka>5) {
        if(pulapka == 6 || pulapka == 7) {
            GameObject nowapulapka = GameObject.Instantiate(siatka);
            nowapulapka.transform.position = miejscespawnu12.transform.position;
        }else {
            if(pulapka == 8 || pulapka == 9) {
            GameObject nowapulapka = GameObject.Instantiate(szczupak);
            nowapulapka.transform.position = miejscespawnu12.transform.position;
            }else {
                if(pulapka == 10) {
            GameObject nowapulapka = GameObject.Instantiate(haczyk);
            nowapulapka.transform.position = miejscespawnu12.transform.position;
                }
            }
        }
       }
    }
    public void generujspawn13() 
    {
       pulapka = Random.Range(1,10);
       if(pulapka>5) {
        if(pulapka == 6 || pulapka == 7) {
            GameObject nowapulapka = GameObject.Instantiate(siatka);
            nowapulapka.transform.position = miejscespawnu13.transform.position;
        }else {
            if(pulapka == 8 || pulapka == 9) {
            GameObject nowapulapka = GameObject.Instantiate(szczupak);
            nowapulapka.transform.position = miejscespawnu13.transform.position;
            }else {
                if(pulapka == 10) {
            GameObject nowapulapka = GameObject.Instantiate(haczyk);
            nowapulapka.transform.position = miejscespawnu13.transform.position;
                }
            }
        }
       }
    }
    public void generujspawn14() 
    {
       pulapka = Random.Range(1,10);
       if(pulapka>5) {
        if(pulapka == 6 || pulapka == 7) {
            GameObject nowapulapka = GameObject.Instantiate(siatka);
            nowapulapka.transform.position = miejscespawnu14.transform.position;
        }else {
            if(pulapka == 8 || pulapka == 9) {
            GameObject nowapulapka = GameObject.Instantiate(szczupak);
            nowapulapka.transform.position = miejscespawnu14.transform.position;
            }else {
                if(pulapka == 10) {
            GameObject nowapulapka = GameObject.Instantiate(haczyk);
            nowapulapka.transform.position = miejscespawnu14.transform.position;
                }
            }
        }
       }
    }
    public void generujspawn15() 
    {
       pulapka = Random.Range(1,10);
       if(pulapka>5) {
        if(pulapka == 6 || pulapka == 7) {
            GameObject nowapulapka = GameObject.Instantiate(siatka);
            nowapulapka.transform.position = miejscespawnu15.transform.position;
        }else {
            if(pulapka == 8 || pulapka == 9) {
            GameObject nowapulapka = GameObject.Instantiate(szczupak);
            nowapulapka.transform.position = miejscespawnu15.transform.position;
            }else {
                if(pulapka == 10) {
            GameObject nowapulapka = GameObject.Instantiate(haczyk);
            nowapulapka.transform.position = miejscespawnu15.transform.position;
                }
            }
        }
       }
    }
    public void generujspawn16() 
    {
       pulapka = Random.Range(1,10);
       if(pulapka>5) {
        if(pulapka == 6 || pulapka == 7) {
            GameObject nowapulapka = GameObject.Instantiate(siatka);
            nowapulapka.transform.position = miejscespawnu16.transform.position;
        }else {
            if(pulapka == 8 || pulapka == 9) {
            GameObject nowapulapka = GameObject.Instantiate(szczupak);
            nowapulapka.transform.position = miejscespawnu16.transform.position;
            }else {
                if(pulapka == 10) {
            GameObject nowapulapka = GameObject.Instantiate(haczyk);
            nowapulapka.transform.position = miejscespawnu16.transform.position;
                }
            }
        }
       }
    }
    public void generujspawn17() 
    {
       pulapka = Random.Range(1,10);
       if(pulapka>5) {
        if(pulapka == 6 || pulapka == 7) {
            GameObject nowapulapka = GameObject.Instantiate(siatka);
            nowapulapka.transform.position = miejscespawnu17.transform.position;
        }else {
            if(pulapka == 8 || pulapka == 9) {
            GameObject nowapulapka = GameObject.Instantiate(szczupak);
            nowapulapka.transform.position = miejscespawnu17.transform.position;
            }else {
                if(pulapka == 10) {
            GameObject nowapulapka = GameObject.Instantiate(haczyk);
            nowapulapka.transform.position = miejscespawnu17.transform.position;
                }
            }
        }
       }
    }
    public void generujspawn18() 
    {
       pulapka = Random.Range(1,10);
       if(pulapka>5) {
        if(pulapka == 6 || pulapka == 7) {
            GameObject nowapulapka = GameObject.Instantiate(siatka);
            nowapulapka.transform.position = miejscespawnu18.transform.position;
        }else {
            if(pulapka == 8 || pulapka == 9) {
            GameObject nowapulapka = GameObject.Instantiate(szczupak);
            nowapulapka.transform.position = miejscespawnu18.transform.position;
            }else {
                if(pulapka == 10) {
            GameObject nowapulapka = GameObject.Instantiate(haczyk);
            nowapulapka.transform.position = miejscespawnu18.transform.position;
                }
            }
        }
       }
    }
    public void generujspawn19() 
    {
       pulapka = Random.Range(1,10);
       if(pulapka>5) {
        if(pulapka == 6 || pulapka == 7) {
            GameObject nowapulapka = GameObject.Instantiate(siatka);
            nowapulapka.transform.position = miejscespawnu19.transform.position;
        }else {
            if(pulapka == 8 || pulapka == 9) {
            GameObject nowapulapka = GameObject.Instantiate(szczupak);
            nowapulapka.transform.position = miejscespawnu19.transform.position;
            }else {
                if(pulapka == 10) {
            GameObject nowapulapka = GameObject.Instantiate(haczyk);
            nowapulapka.transform.position = miejscespawnu19.transform.position;
                }
            }
        }
       }
    }
    public void generujspawn20() 
    {
       pulapka = Random.Range(1,10);
       if(pulapka>5) {
        if(pulapka == 6 || pulapka == 7) {
            GameObject nowapulapka = GameObject.Instantiate(siatka);
            nowapulapka.transform.position = miejscespawnu20.transform.position;
        }else {
            if(pulapka == 8 || pulapka == 9) {
            GameObject nowapulapka = GameObject.Instantiate(szczupak);
            nowapulapka.transform.position = miejscespawnu20.transform.position;
            }else {
                if(pulapka == 10) {
            GameObject nowapulapka = GameObject.Instantiate(haczyk);
            nowapulapka.transform.position = miejscespawnu20.transform.position;
                }
            }
        }
       }
    }
    public void generujspawn21() 
    {
       pulapka = Random.Range(1,10);
       if(pulapka>5) {
        if(pulapka == 6 || pulapka == 7) {
            GameObject nowapulapka = GameObject.Instantiate(siatka);
            nowapulapka.transform.position = miejscespawnu21.transform.position;
        }else {
            if(pulapka == 8 || pulapka == 9) {
            GameObject nowapulapka = GameObject.Instantiate(szczupak);
            nowapulapka.transform.position = miejscespawnu21.transform.position;
            }else {
                if(pulapka == 10) {
            GameObject nowapulapka = GameObject.Instantiate(haczyk);
            nowapulapka.transform.position = miejscespawnu21.transform.position;
                }
            }
        }
       }
    }
    public void generujspawn22() 
    {
       pulapka = Random.Range(1,10);
       if(pulapka>5) {
        if(pulapka == 6 || pulapka == 7) {
            GameObject nowapulapka = GameObject.Instantiate(siatka);
            nowapulapka.transform.position = miejscespawnu22.transform.position;
        }else {
            if(pulapka == 8 || pulapka == 9) {
            GameObject nowapulapka = GameObject.Instantiate(szczupak);
            nowapulapka.transform.position = miejscespawnu22.transform.position;
            }else {
                if(pulapka == 10) {
            GameObject nowapulapka = GameObject.Instantiate(haczyk);
            nowapulapka.transform.position = miejscespawnu22.transform.position;
                }
            }
        }
       }
    }
    public void generujspawn23() 
    {
       pulapka = Random.Range(1,10);
       if(pulapka>5) {
        if(pulapka == 6 || pulapka == 7) {
            GameObject nowapulapka = GameObject.Instantiate(siatka);
            nowapulapka.transform.position = miejscespawnu23.transform.position;
        }else {
            if(pulapka == 8 || pulapka == 9) {
            GameObject nowapulapka = GameObject.Instantiate(szczupak);
            nowapulapka.transform.position = miejscespawnu23.transform.position;
            }else {
                if(pulapka == 10) {
            GameObject nowapulapka = GameObject.Instantiate(haczyk);
            nowapulapka.transform.position = miejscespawnu23.transform.position;
                }
            }
        }
       }
    }
    public void generujspawn24() 
    {
       pulapka = Random.Range(1,10);
       if(pulapka>5) {
        if(pulapka == 6 || pulapka == 7) {
            GameObject nowapulapka = GameObject.Instantiate(siatka);
            nowapulapka.transform.position = miejscespawnu24.transform.position;
        }else {
            if(pulapka == 8 || pulapka == 9) {
            GameObject nowapulapka = GameObject.Instantiate(szczupak);
            nowapulapka.transform.position = miejscespawnu24.transform.position;
            }else {
                if(pulapka == 10) {
            GameObject nowapulapka = GameObject.Instantiate(haczyk);
            nowapulapka.transform.position = miejscespawnu24.transform.position;
                }
            }
        }
       }
    }
    public void generujspawn25() 
    {
       pulapka = Random.Range(1,10);
       if(pulapka>5) {
        if(pulapka == 6 || pulapka == 7) {
            GameObject nowapulapka = GameObject.Instantiate(siatka);
            nowapulapka.transform.position = miejscespawnu25.transform.position;
        }else {
            if(pulapka == 8 || pulapka == 9) {
            GameObject nowapulapka = GameObject.Instantiate(szczupak);
            nowapulapka.transform.position = miejscespawnu25.transform.position;
            }else {
                if(pulapka == 10) {
            GameObject nowapulapka = GameObject.Instantiate(haczyk);
            nowapulapka.transform.position = miejscespawnu25.transform.position;
                }
            }
        }
       }
    }
    public void generujspawn26() 
    {
       pulapka = Random.Range(1,10);
       if(pulapka>5) {
        if(pulapka == 6 || pulapka == 7) {
            GameObject nowapulapka = GameObject.Instantiate(siatka);
            nowapulapka.transform.position = miejscespawnu26.transform.position;
        }else {
            if(pulapka == 8 || pulapka == 9) {
            GameObject nowapulapka = GameObject.Instantiate(szczupak);
            nowapulapka.transform.position = miejscespawnu26.transform.position;
            }else {
                if(pulapka == 10) {
            GameObject nowapulapka = GameObject.Instantiate(haczyk);
            nowapulapka.transform.position = miejscespawnu26.transform.position;
                }
            }
        }
       }
    }
    public void generujspawn27() 
    {
       pulapka = Random.Range(1,10);
       if(pulapka>5) {
        if(pulapka == 6 || pulapka == 7) {
            GameObject nowapulapka = GameObject.Instantiate(siatka);
            nowapulapka.transform.position = miejscespawnu27.transform.position;
        }else {
            if(pulapka == 8 || pulapka == 9) {
            GameObject nowapulapka = GameObject.Instantiate(szczupak);
            nowapulapka.transform.position = miejscespawnu27.transform.position;
            }else {
                if(pulapka == 10) {
            GameObject nowapulapka = GameObject.Instantiate(haczyk);
            nowapulapka.transform.position = miejscespawnu27.transform.position;
                }
            }
        }
       }
    }
    public void generujspawn28() 
    {
       pulapka = Random.Range(1,10);
       if(pulapka>5) {
        if(pulapka == 6 || pulapka == 7) {
            GameObject nowapulapka = GameObject.Instantiate(siatka);
            nowapulapka.transform.position = miejscespawnu28.transform.position;
        }else {
            if(pulapka == 8 || pulapka == 9) {
            GameObject nowapulapka = GameObject.Instantiate(szczupak);
            nowapulapka.transform.position = miejscespawnu28.transform.position;
            }else {
                if(pulapka == 10) {
            GameObject nowapulapka = GameObject.Instantiate(haczyk);
            nowapulapka.transform.position = miejscespawnu28.transform.position;
                }
            }
        }
       }
    }
    public void generujspawn29() 
    {
       pulapka = Random.Range(1,10);
       if(pulapka>5) {
        if(pulapka == 6 || pulapka == 7) {
            GameObject nowapulapka = GameObject.Instantiate(siatka);
            nowapulapka.transform.position = miejscespawnu29.transform.position;
        }else {
            if(pulapka == 8 || pulapka == 9) {
            GameObject nowapulapka = GameObject.Instantiate(szczupak);
            nowapulapka.transform.position = miejscespawnu29.transform.position;
            }else {
                if(pulapka == 10) {
            GameObject nowapulapka = GameObject.Instantiate(haczyk);
            nowapulapka.transform.position = miejscespawnu29.transform.position;
                }
            }
        }
       }
    }
    public void generujwszystko() 
    {
        generujmiejscegraczaigowna();
        przywolajgracza();
        przywolajgowno();
        generujspawn1();
        generujspawn2();
        generujspawn3();
        generujspawn4();
        generujspawn5();
        generujspawn6();
        generujspawn7();
        generujspawn8();
        generujspawn9();
        generujspawn10();
        generujspawn12();
        generujspawn13();
        generujspawn14();
        generujspawn15();
        generujspawn16();
        generujspawn17();
        generujspawn18();
        generujspawn19();
        generujspawn20();
        generujspawn21();
        generujspawn22();
        generujspawn23();
        generujspawn24();
        generujspawn25();
        generujspawn26();
        generujspawn27();
        generujspawn28();
        generujspawn29();
    }
    // Start is called before the first frame update
    void Start()
    {
        generujwszystko();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
