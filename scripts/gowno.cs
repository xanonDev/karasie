using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gowno : MonoBehaviour
{  
    public GameObject player;
    public GameObject eatanimation;
    public GameObject skinplayer;
    public GameObject karaswanimacji;

    IEnumerator waiter() 
    {
        yield return new WaitForSeconds(1.9f);
        Application.LoadLevel(Application.loadedLevel);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player"){
        eatanimation.SetActive(true);
        Sprite skingracza = skinplayer.GetComponent<SpriteRenderer>().sprite;
        karaswanimacji.GetComponent<UnityEngine.UI.Image>().sprite = skingracza;
        eatanimation.GetComponent<Animator>().enabled = true;
        skinplayer.GetComponent<playermove>().enabled = false;
        skinplayer.GetComponent<BoxCollider2D>().enabled = false;
        player.GetComponent<level>().lvlpoint++;
        StartCoroutine(waiter());
        }else {
            if(col.tag == "pulapka") {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }
}
