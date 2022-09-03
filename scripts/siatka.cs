using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class siatka : MonoBehaviour
{
    public GameObject gracz;
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Player"){
        Application.LoadLevel(Application.loadedLevel);
        }
    }
}
