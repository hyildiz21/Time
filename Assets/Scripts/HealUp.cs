using UnityEngine;

public class HealUp : MonoBehaviour
{

    private void Start()
    {
        //gameObject.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.transform.tag == "Player")
        {
            FindObjectOfType<SesKontrol>().CanToplaSes();
            collision.GetComponent<PlayerStats>().Regen(1);
            Destroy(gameObject, 0.3f);
            
        }
    }

    public void HealAc()
    {
        gameObject.SetActive(true);
    }



}
