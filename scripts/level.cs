using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level : MonoBehaviour
{
    public int lvl;
    public int lvlpoint;
    public int donextlvl;
    public int skin;
    public int uzyciabomby = 1;
    public GameObject player;
    public GameObject bomba;
    public GameObject bombspawn;
    public GameObject mieczezoro;
    public GameObject mieczspawn;
    public GameObject todorokiabity;
    public GameObject getsugatensho;
    public GameObject chidori;
    public GameObject zawarudo;
    public GameObject przyciskumiejetnosci;
    public Text lvltext;
    public Slider progressbar;
    public Sprite zwyklyskin;
    public Sprite biznesman;
    public Sprite emo;
    public Sprite seba;
    public Sprite anime;
    public Sprite kigurumi;
    public Sprite nagito;
    public Sprite zoro;
    public Sprite todoroki;
    public Sprite ichigo;
    public Sprite sasuke;
    public Sprite dio;
    public Sprite ogien;
    public Sprite lod;
    // Start is called before the first frame update
    IEnumerator chidoriprzod() 
    {
        yield return new WaitForSeconds(0.1f);
        player.transform.position = new Vector3(player.transform.position.x + 5f, player.transform.position.y, player.transform.position.z);
        player.GetComponent<playermove>().enabled = true;
    }
    IEnumerator chidorityl() 
    {
        yield return new WaitForSeconds(0.1f);
        player.transform.position = new Vector3(player.transform.position.x - 5f, player.transform.position.y, player.transform.position.z);
        player.GetComponent<playermove>().enabled = true;
    }
    IEnumerator zawarudostart() 
    {
        player.GetComponent<BoxCollider2D>().enabled = false;
        zawarudo.SetActive(true);
        yield return new WaitForSeconds(5);
        player.GetComponent<BoxCollider2D>().enabled = true;
        zawarudo.SetActive(false);
    }
    public void umiejetnoscnagito()
    {
        if(skin == 7 && uzyciabomby > 0) {
        GameObject nowabomba = GameObject.Instantiate(bomba);
        nowabomba.transform.position = bombspawn.transform.position;
        uzyciabomby--;
        }
    }
    public void umiejetnosczoro()
    {
        if(skin == 8 && uzyciabomby > 0) {
        GameObject nowymiecz = GameObject.Instantiate(mieczezoro);
        nowymiecz.transform.position = mieczspawn.transform.position;
        if(player.GetComponent<playermove>().spawnprzod.transform.position == player.GetComponent<playermove>().przod.transform.position)
        {
           
        }else {
            if(player.GetComponent<playermove>().spawnprzod.transform.position == player.GetComponent<playermove>().przod.transform.position)
        {
            
        }
        }
        uzyciabomby--;
        }
    }
    public void umiejetnosctodorokiego()
    {
        if(skin == 9 && uzyciabomby > 0) {
        int lodczyogien = Random.Range(1, 2);
        if(lodczyogien == 1){
        todorokiabity.GetComponent<SpriteRenderer>().sprite = lod;
        todorokiabity.SetActive(true);
        }else {
            if(lodczyogien == 2) {
                todorokiabity.GetComponent<SpriteRenderer>().sprite = ogien;
                todorokiabity.SetActive(false);
            }
        }
        uzyciabomby--;
        }
    }
     public void umiejetnoscitchigo()
    {
        if(skin == 10 && uzyciabomby > 0) {
        GameObject getsuga1 = GameObject.Instantiate(getsugatensho);
        GameObject getsuga2 = GameObject.Instantiate(getsugatensho);
        getsuga2.GetComponent<SpriteRenderer>().flipX = true;
        getsuga1.transform.position = player.GetComponent<playermove>().przod.transform.position;
        getsuga2.transform.position = player.GetComponent<playermove>().tyl.transform.position;
        getsuga1.GetComponent<getsugatensho>().przodczytyl = 1;
        getsuga2.GetComponent<getsugatensho>().przodczytyl = 2;
        uzyciabomby--;
        }
    }
    public void umiejetnoscsasuke()
    {
        if(skin == 11 && uzyciabomby > 0) {
        GameObject chidorinowe = GameObject.Instantiate(chidori);
        chidorinowe.transform.position = mieczspawn.transform.position;
        if(player.GetComponent<playermove>().przod.transform.position == mieczspawn.transform.position)
        {
            player.GetComponent<playermove>().enabled = false;
            chidorinowe.transform.position = new Vector3(chidorinowe.transform.position.x + 5f, chidorinowe.transform.position.y, chidorinowe.transform.position.z);
            StartCoroutine(chidoriprzod());
            
        }else {
            if(player.GetComponent<playermove>().tyl.transform.position == mieczspawn.transform.position)
            {
            player.GetComponent<playermove>().enabled = false;
            chidorinowe.transform.position = new Vector3(chidorinowe.transform.position.x - 5f, chidorinowe.transform.position.y, chidorinowe.transform.position.z);
            StartCoroutine(chidorityl());
            
            }
        }
        uzyciabomby--;
        }
    }
    public void umiejetnoscdio()
    {
        if(skin == 12 && uzyciabomby > 0) {
        StartCoroutine(zawarudostart());
        uzyciabomby--;
        }
    }
    void Start()
    {
        lvl = PlayerPrefs.GetInt("lvl", 1);
        lvlpoint = PlayerPrefs.GetInt("lvlpoint", 0);
        donextlvl = PlayerPrefs.GetInt("donextlvl", 1);
        skin = PlayerPrefs.GetInt("skin", 1);

    }

    public void jakiskin()
    {
        if(skin == 1) {
            player.GetComponent<SpriteRenderer>().sprite = zwyklyskin;
        }else {
            if(skin == 2) {
                player.GetComponent<SpriteRenderer>().sprite = biznesman;
            }else {
                if(skin == 3) {
                    player.GetComponent<SpriteRenderer>().sprite = emo;
                }else {
                    if(skin == 4) {
                        player.GetComponent<SpriteRenderer>().sprite = seba;
                    }else {
                        if(skin == 5) {
                            player.GetComponent<SpriteRenderer>().sprite = anime;
                        }else {
                            if(skin == 6) {
                                player.GetComponent<SpriteRenderer>().sprite = kigurumi;
                            }else{
                                if(skin == 7) {
                                player.GetComponent<SpriteRenderer>().sprite = nagito;
                                if(Input.GetKey(KeyCode.Alpha1)){
                                umiejetnoscnagito();
                                }
                            }else {
                                if(skin == 8) {
                                player.GetComponent<SpriteRenderer>().sprite = zoro;
                                if(Input.GetKey(KeyCode.Alpha1)) {
                                umiejetnosczoro();
                                }
                            }else {
                                if(skin == 9) {
                                player.GetComponent<SpriteRenderer>().sprite = todoroki;
                                if(Input.GetKey(KeyCode.Alpha1)) {
                                umiejetnosctodorokiego();
                                }
                            }else {
                                if(skin == 10) {
                                player.GetComponent<SpriteRenderer>().sprite = ichigo;
                                if(Input.GetKey(KeyCode.Alpha1)) {
                                umiejetnoscitchigo();
                                }
                            }else {
                                if(skin == 11) {
                                player.GetComponent<SpriteRenderer>().sprite = sasuke;
                                if(Input.GetKey(KeyCode.Alpha1)) {
                                umiejetnoscsasuke();
                                }
                            }else {
                                if(skin == 12) {
                                player.GetComponent<SpriteRenderer>().sprite = dio;
                                if(Input.GetKey(KeyCode.Alpha1)) {
                                umiejetnoscdio();
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
    public void przyciskability()
    {
        if(skin >= 7)
        {
            przyciskumiejetnosci.SetActive(true);
            przyciskumiejetnosci.GetComponent<Image>().sprite = player.GetComponent<SpriteRenderer>().sprite;

        }else {
            przyciskumiejetnosci.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        jakiskin();
        lvltext.text = "level " + lvl;
        progressbar.maxValue = donextlvl;
        progressbar.value = lvlpoint;
        PlayerPrefs.SetInt("lvl", lvl);
        PlayerPrefs.SetInt("lvlpoint", lvlpoint);
        PlayerPrefs.SetInt("donextlvl", donextlvl);
        PlayerPrefs.SetInt("skin", skin);
        PlayerPrefs.Save();
        if(lvlpoint == donextlvl){
            lvl++;
            donextlvl = donextlvl * 2;
            lvlpoint = 0;
        }
        przyciskability();
    }
}
