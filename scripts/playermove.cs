using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public GameObject gracz;
    public GameObject przod;
    public GameObject tyl;
    public GameObject spawnprzod;
    public float szybkosc = 0.03f;

    public void W() {
        gracz.transform.position = new Vector3(gracz.transform.position.x, gracz.transform.position.y + szybkosc , gracz.transform.position.z);
    }
    public void S() {
        gracz.transform.position = new Vector3(gracz.transform.position.x , gracz.transform.position.y - szybkosc, gracz.transform.position.z);
    }
    public void D() {
        gracz.transform.position = new Vector3(gracz.transform.position.x + szybkosc , gracz.transform.position.y, gracz.transform.position.z);
        gracz.GetComponent<SpriteRenderer>().flipX = false;
        spawnprzod.transform.position = przod.transform.position;
    }
    public void A() {
        gracz.transform.position = new Vector3(gracz.transform.position.x - szybkosc, gracz.transform.position.y, gracz.transform.position.z);
        gracz.GetComponent<SpriteRenderer>().flipX = true;
        spawnprzod.transform.position = tyl.transform.position;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if(Input.GetKey(KeyCode.W)){

       gracz.transform.position = new Vector3(gracz.transform.position.x, gracz.transform.position.y + szybkosc , gracz.transform.position.z);

    }else{
    if(Input.GetKey(KeyCode.S))
   {
    gracz.transform.position = new Vector3(gracz.transform.position.x , gracz.transform.position.y - szybkosc, gracz.transform.position.z);
    }else {
        if(Input.GetKey(KeyCode.D))
   {
    gracz.transform.position = new Vector3(gracz.transform.position.x + szybkosc , gracz.transform.position.y, gracz.transform.position.z);
    gracz.GetComponent<SpriteRenderer>().flipX = false;
    spawnprzod.transform.position = przod.transform.position;
    }else{
       if(Input.GetKey(KeyCode.A))
   {
    gracz.transform.position = new Vector3(gracz.transform.position.x - szybkosc, gracz.transform.position.y, gracz.transform.position.z);
    gracz.GetComponent<SpriteRenderer>().flipX = true;
    spawnprzod.transform.position = tyl.transform.position;
    } 
    }

    }

   }
   
    }
}
