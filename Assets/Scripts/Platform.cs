using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    //BU SCRIPT YEN�DEN ZIPLAMA ��LEM�N� GER�EKLE�T�RMEK ���N VAR
    
   

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Ayaklar")
        {
            
            //GameObject.FindGameObjectWithTag("Player").transform.parent = transform; //sen nereye hareket edersen yani platform cassie de etsin �st�nde
            GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<PlayerKontrol>().ZiplamaSifirla();
            
        }
    }
}
