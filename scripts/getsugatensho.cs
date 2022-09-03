using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getsugatensho : MonoBehaviour
{
    public float speed = 0.1f;
    public int przodczytyl;
    IEnumerator tenshoprzod() 
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x + speed, gameObject.transform.position.y, gameObject.transform.position.z);
        yield return new WaitForSeconds(0.5f);
        gameObject.transform.position = new Vector3(gameObject.transform.position.x + speed, gameObject.transform.position.y, gameObject.transform.position.z);
        yield return new WaitForSeconds(0.5f);
        gameObject.transform.position = new Vector3(gameObject.transform.position.x + speed, gameObject.transform.position.y, gameObject.transform.position.z);
        yield return new WaitForSeconds(0.5f);
        gameObject.transform.position = new Vector3(gameObject.transform.position.x + speed, gameObject.transform.position.y, gameObject.transform.position.z);
        yield return new WaitForSeconds(0.5f);
        gameObject.transform.position = new Vector3(gameObject.transform.position.x + speed, gameObject.transform.position.y, gameObject.transform.position.z);
        Destroy(gameObject);
    }
    IEnumerator tenshotyl() 
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x - speed, gameObject.transform.position.y, gameObject.transform.position.z);
        yield return new WaitForSeconds(0.5f);
        gameObject.transform.position = new Vector3(gameObject.transform.position.x - speed, gameObject.transform.position.y, gameObject.transform.position.z);
        yield return new WaitForSeconds(0.5f);
        gameObject.transform.position = new Vector3(gameObject.transform.position.x - speed, gameObject.transform.position.y, gameObject.transform.position.z);
        yield return new WaitForSeconds(0.5f);
        gameObject.transform.position = new Vector3(gameObject.transform.position.x - speed, gameObject.transform.position.y, gameObject.transform.position.z);
        yield return new WaitForSeconds(0.5f);
        gameObject.transform.position = new Vector3(gameObject.transform.position.x - speed, gameObject.transform.position.y, gameObject.transform.position.z);
        Destroy(gameObject);
    }
    void Update()
    {
        if(przodczytyl == 1)
        {
        StartCoroutine(tenshoprzod());
        }else {
            if(przodczytyl == 2) {
        StartCoroutine(tenshotyl());
            }
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "pulapka"){
            col.GetComponent<SpriteRenderer>().enabled = false;
            Destroy(col);
        }
    }
}
