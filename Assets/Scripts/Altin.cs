using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Altin : MonoBehaviour
{
    [SerializeField] GameObject AltinSprite;


    public void AltiniAc()
    {
        gameObject.SetActive(true);
    }

    public void AltinKapat()
    {
        gameObject.SetActive(false);
    }

}
