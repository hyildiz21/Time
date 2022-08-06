using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    //UI


    [SerializeField] Image[] hearts;
    Animator myanimator;


    public int health = 5; //þuanki can
    int maxHealth = 5;

    


    public void Start()
    {
        myanimator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (health > maxHealth)
        {
            health = maxHealth;
        }
        //oyunBitti metodu
        if (health == 0)
        {
            myanimator.SetTrigger("Death");
            Destroy(gameObject, 0.45f);

        }

        //if (Input.GetKeyDown(KeyCode.H))//kaldýrýlacak
        //{
        //    if (health > 0)
        //    {
        //        Damage(1);
        //    }
        //}
        //if (Input.GetKeyUp(KeyCode.J))//kaldýrýlacak
        //{
        //    if (health<maxHealth)
        //    {
        //        Regen(1);
        //    }
        //}
    }

    /// <summary>
    /// Hasar alýnca sol üstteki canlar 1 eksilir.
    /// </summary>
    /// <param name="deger"></param>
    public void Damage(int deger)
    {
        hearts[health - 1].enabled = false;
        health -= deger;

    }

    /// <summary>
    /// Yeniden can doldurma, sol üstteki canlar sýrasý ile 1 artar max can=5
    /// </summary>
    /// <param name="deger"></param>
    public void Regen(int deger)
    {
        health += deger;

        for (int i = 0; i < health; i++)
        {
            if (health<=5)
            {
                hearts[i].enabled = true;
            }
            
        }
    }

    //mermi çarpýnca çaðrýlan animasyon
    public void HitAnimasyonEtkinlestir()
    {
        myanimator.SetTrigger("Hit");
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.transform.tag == "Enemy")
        {
            FindObjectOfType<SesKontrol>().HasarYeSes();
            Damage(1);
            myanimator.SetTrigger("Hit");
        }

        if (health == 0)
        {
            FindObjectOfType<SesKontrol>().OlumSes();
            myanimator.SetTrigger("Death");
            Destroy(gameObject, 0.5f);

            //if (GameObject.FindGameObjectWithTag("Enemy"))
            //{
            //    Debug.Log("x");
            //    Destroy(GameObject.Find("Mushroomm"));
            //}

            if (GameObject.FindGameObjectWithTag("OyunKontrol"))
            {
                Debug.Log("1.bmolum sonu");
                FindObjectOfType<OyunKontrol>().OyunBitir();

            }
            if (GameObject.FindGameObjectWithTag("OyunKontrol1"))
            {
                Debug.Log("2.bmolum sonu");
                FindObjectOfType<OyunKontrol1>().OyunBitir1();
            }
            if (GameObject.FindGameObjectWithTag("OyunKontrol2"))
            {
                Debug.Log("3.bmolum sonu");
                FindObjectOfType<OyunKontrol2>().OyunBitir2();
            }
            if (GameObject.FindGameObjectWithTag("OyunKontrol3"))
            {
                Debug.Log("4.bmolun sonu");
                FindObjectOfType<Oyunkontrol3>().OyunBitir3();
            }
            //FindObjectOfType<EnemyHealth>().DusmanKapa(); 


        }

        if (collision.gameObject.tag == "Olum")
        {
            FindObjectOfType<SesKontrol>().OlumSes();
            myanimator.SetTrigger("Death");
            Destroy(gameObject, 0.5f);


            if (GameObject.FindGameObjectWithTag("OyunKontrol"))
            {
                Debug.Log("1.bmolum sonu");
                FindObjectOfType<OyunKontrol>().OyunBitir();

            }
            if (GameObject.FindGameObjectWithTag("OyunKontrol1"))
            {
                Debug.Log("2.bmolum sonu");
                FindObjectOfType<OyunKontrol1>().OyunBitir1();
            }
            if (GameObject.FindGameObjectWithTag("OyunKontrol2"))
            {
                Debug.Log("3.bmolum sonu");
                FindObjectOfType<OyunKontrol2>().OyunBitir2();
            }
            if (GameObject.FindGameObjectWithTag("OyunKontrol3"))
            {
                Debug.Log("4.bmolun sonu");
                FindObjectOfType<Oyunkontrol3>().OyunBitir3();
            }



            //FindObjectOfType<EnemyHealth>().DusmanKapa(); 


        }


    }






}
