using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformHareket : MonoBehaviour
{
    public Transform ilkPoz, ikinciPoz;
    float platformHiz;

    Vector3 sonrakiPoz;

    // Start is called before the first frame update
    void Start()
    {
        platformHiz = Random.Range(1f, 5f);
        sonrakiPoz = ilkPoz.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position==ilkPoz.position)
        {
            sonrakiPoz = ikinciPoz.position;
        }
        if (transform.position==ikinciPoz.position)
        {
            sonrakiPoz = ilkPoz.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, sonrakiPoz, platformHiz * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.transform.tag=="Player")
        {
            collision.collider.transform.SetParent(transform); //??
        }
        

        if (collision.gameObject.transform.tag=="Ayaklar")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<PlayerKontrol>().ZiplamaSifirla();
        }
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.transform.tag=="Player")
        {
            collision.collider.transform.SetParent(null);
        }
    }

    //void YukariHareket()
    //{
    //    transform.position=Vector3.MoveTowards
    //}

    /// <summary>
    /// 1. ve 2. pozisyonlar arasý çizgi çizer.
    /// </summary>
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(ilkPoz.position, ikinciPoz.position);
    }




}
