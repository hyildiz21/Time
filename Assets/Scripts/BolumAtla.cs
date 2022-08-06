using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BolumAtla : MonoBehaviour
{
    //bool sonBolumMu = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.transform.tag == "Player")
        {
            
            OyunSahnesiYukle();

        }
    }

    public void OyunSahnesiYukle() //her sahnedeki kapýya girdiðinde hangi indexteyse 1 fazlasý için
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //if ((SceneManager.)
        //{
        //    OyunBittiMenuDon();
        //}
    }

    //void OyunBittiMenuDon()
    //{


    //    SceneManager.LoadScene("Menu"); //menu ekraný

    //}


}
