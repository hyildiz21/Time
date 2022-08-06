using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{
    [SerializeField] GameObject baslaButon;
    public Sprite[] muzik = default;
    public Button muzikButon;

    // Start is called before the first frame update
    void Start()
    {
        if (Secenekler.MuzikKayitVarMi() == false) //müzikle alakalý bir kayýt yoksa müzik açýk gelsin default olarak
        {
            Secenekler.MuzikDegerAta(1);
        }
        MuzikAyarlariKontrol();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Muzik()
    {
        if (Secenekler.MuzikDegerOku() == 1)
        {
            Secenekler.MuzikDegerAta(0);
            MuzikKontrol.instance.MuzikCal(false);
            muzikButon.image.sprite = muzik[0];
        }
        else
        {
            Secenekler.MuzikDegerAta(1);
            MuzikKontrol.instance.MuzikCal(true);
            muzikButon.image.sprite = muzik[1];
        }
    }

    void MuzikAyarlariKontrol()
    {
        if (Secenekler.MuzikDegerOku() == 1) //yani müzik kaydý varsa müzik açýk
        {
            muzikButon.image.sprite = muzik[1];
            MuzikKontrol.instance.MuzikCal(true);
        }
        else
        {
            muzikButon.image.sprite = muzik[0];
            MuzikKontrol.instance.MuzikCal(false);
        }
    }


    public void OyunYukle()
    {
        SceneManager.LoadScene("SonSahne");
    }

    public void OyunCikis()
    {
        Application.Quit();
    }



}
