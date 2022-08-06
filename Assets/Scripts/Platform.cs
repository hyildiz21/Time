using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    //BU SCRIPT YENÝDEN ZIPLAMA ÝÞLEMÝNÝ GERÇEKLEÞTÝRMEK ÝÇÝN VAR
    
   

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Ayaklar")
        {
            
            //GameObject.FindGameObjectWithTag("Player").transform.parent = transform; //sen nereye hareket edersen yani platform cassie de etsin üstünde
            GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<PlayerKontrol>().ZiplamaSifirla();
            
        }
    }
}
