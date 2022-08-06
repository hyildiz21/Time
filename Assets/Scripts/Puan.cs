using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puan : MonoBehaviour
{
    int altin;

    [SerializeField] Text AltinText;
    [SerializeField] Text PanelAltinText;


    // Start is called before the first frame update
    void Start()
    {
        AltinText.text = "X" + altin;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AltinKazan()
    {
        FindObjectOfType<SesKontrol>().AltinSes();
        altin++;
        AltinText.text = "X" + altin;
    }

    public void OyunBittiPanel()
    {
        PanelAltinText.text = " X " + altin;
    }
}
