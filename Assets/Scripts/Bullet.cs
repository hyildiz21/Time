using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    public Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = transform.right * bulletSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 4f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.transform.tag == "Player")
        {
            FindObjectOfType<SesKontrol>().HasarYeSes();
            Debug.Log("hasar alýyorsun");
            FindObjectOfType<PlayerStats>().Damage(1);
            FindObjectOfType<PlayerStats>().HitAnimasyonEtkinlestir();

            if (GameObject.FindGameObjectWithTag("OyunKontrol")) //hangi seviyede ölüyorsa o kontroldeki bitirme metodu çaðrýlsýn
            {
                if (FindObjectOfType<PlayerStats>().health == 0)
                {
                    FindObjectOfType<OyunKontrol>().OyunBitir();
                }
            }
            if (GameObject.FindGameObjectWithTag("OyunKontrol2"))
            {
                if (FindObjectOfType<PlayerStats>().health == 0)
                {
                    FindObjectOfType<OyunKontrol2>().OyunBitir2();
                }
            }
            if (GameObject.FindGameObjectWithTag("OyunKontrol3"))
            {
                if (FindObjectOfType<PlayerStats>().health == 0)
                {
                    FindObjectOfType<Oyunkontrol3>().OyunBitir3();
                }
            }


        }
    }

    
}
