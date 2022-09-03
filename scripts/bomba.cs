using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomba : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "pulapka"){
            Destroy(gameObject);
            col.GetComponent<SpriteRenderer>().enabled = false;
            Destroy(col);
        }
    }
}
