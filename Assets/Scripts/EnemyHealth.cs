using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;

    private void Start()
    {
        //DusmanKapa();
    }

    private void Update()
    {

    }


    public void GetDamage(int amount)
    {

        health -= amount;

        if (health <= 0)
        {
            Destroy(gameObject, 0.3f);
        }
    }


    public void DusmanAc()
    {
        gameObject.SetActive(true);
    }

    /// <summary>
    /// hem mermi hem de düþmaný kapatýcak oyun bitince
    /// </summary>
    public void DusmanKapa()
    {
        if (gameObject.tag == "Enemy" || gameObject.name == "Mushroomm")
        {
            gameObject.SetActive(false);
            


        }

    }


}
