using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firepoint : MonoBehaviour
{
    //oyun ba�lar ba�lamaz enemyler kapal� olsun biz bi trigger yapal�m sonra aktifle�sin

    public Transform firepoint;
    public GameObject bulletPrefab;
    float tekrarSure;
    public float starttimeBetween;

    //hemen instantiate olmas�n� istemiom

    // Start is called before the first frame update
    void Start()
    {
        
        tekrarSure = starttimeBetween;

    }

    // Update is called once per frame
    void Update()
    {
        MermiUret();

    }

    public void MermiUret()
    {
        if (tekrarSure <= 0)
        {
            Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
            tekrarSure = starttimeBetween;
        }
        else
        {
            tekrarSure -= Time.deltaTime;
        }

    }
    
    

    



}
