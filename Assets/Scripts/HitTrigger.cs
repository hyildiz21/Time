using UnityEngine;

public class HitTrigger : MonoBehaviour
{
   
    public int damage;
    //Deðiþecek düþman deðilde propslarý kesme kýrma olsun.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag=="Enemy")
        {
            collision.GetComponent<EnemyHealth>().GetDamage(damage);
                     
        }

    }


    
}
