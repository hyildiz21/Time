using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesKontrol : MonoBehaviour
{
    public AudioClip ziplama;
    public AudioClip altin;
    public AudioClip saldiri;
    public AudioClip dash;
    public AudioClip olum;
    public AudioClip hasarYe;
    public AudioClip heal;
    public AudioClip hareket;
    

    AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ZiplamaSes()
    {
        audioSource.clip = ziplama;
        audioSource.Play();
    }
    public void AltinSes()
    {
        audioSource.clip = altin;
        audioSource.Play();
    }
    public void SaldiriSes()
    {
        audioSource.clip = saldiri;
        audioSource.Play();
    }
    public void DashSes()
    {
        audioSource.clip = dash;
        audioSource.Play();
    }
    public void OlumSes()
    {
        audioSource.clip = olum;
        audioSource.Play();
    }
    public void HasarYeSes()
    {
        audioSource.clip = hasarYe;
        audioSource.Play();
    }
    public void CanToplaSes()
    {
        audioSource.clip = heal;
        audioSource.Play();
    }
    public void HareketEtSes()
    {
        audioSource.clip = hareket;
        audioSource.Play();
    }


}
