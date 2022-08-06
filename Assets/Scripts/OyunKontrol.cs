using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyunKontrol : MonoBehaviour
{
    public GameObject GameOverPanel;
    public GameObject AnaMenuButon;
    public GameObject AltinImage;
    public GameObject Slider;
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;
    public GameObject Heart4;
    public GameObject Heart5;

    public GameObject[] enemy = new GameObject[4];

    //slider da eklenecek

    // Start is called before the first frame update
    void Start()
    {
        GameOverPanel.gameObject.SetActive(false);
        UIAc();
    }

    // Update is called once per frame
    void Update()
    {

    }

    

    public void OyunBitir()
    {
        Debug.Log("Oyun bitecek");
        GameOverPanel.SetActive(true);
        UIKapa();
        FindObjectOfType<Puan>().OyunBittiPanel();
        FindObjectOfType<PlayerKontrol>().HareketEdemez();
        for (int i = 0; i < enemy.Length; i++)
        {
            //FindObjectOfType<EnemyHealth>().DusmanKapa();
            enemy[i].SetActive(false);
        }



    }


    public void AnaMenuDon()
    {
        SceneManager.LoadScene("Menu");
    }
    public void OyunuTekrarYukle()
    {
        SceneManager.LoadScene("SonSahne");
    }

    //5 ayr� obje ile �al���ypr ama list ile olmad� for d�ng�s�nd
    public void UIAc()
    {
        AnaMenuButon.gameObject.SetActive(true);
        AltinImage.gameObject.SetActive(true);
        Slider.gameObject.SetActive(true);
        Heart1.gameObject.SetActive(true);
        Heart2.gameObject.SetActive(true);
        Heart3.gameObject.SetActive(true);
        Heart4.gameObject.SetActive(true);
        Heart5.gameObject.SetActive(true);

    }

    public void UIKapa()
    {
        AnaMenuButon.gameObject.SetActive(false);
        AltinImage.gameObject.SetActive(false);
        Slider.gameObject.SetActive(false);
        Heart1.gameObject.SetActive(false);
        Heart2.gameObject.SetActive(false);
        Heart3.gameObject.SetActive(false);
        Heart4.gameObject.SetActive(false);
        Heart5.gameObject.SetActive(false);
    }

}
