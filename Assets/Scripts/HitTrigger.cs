using UnityEngine;

public class HitTrigger : MonoBehaviour
{
   
    public int damage;
    //De�i�ecek d��man de�ilde propslar� kesme k�rma olsun.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag=="Enemy")
        {
            collision.GetComponent<EnemyHealth>().GetDamage(damage);
                     
        }

    }


    
}
