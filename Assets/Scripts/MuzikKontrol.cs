using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MuzikKontrol : MonoBehaviour
{
    public static MuzikKontrol instance;
    AudioSource audioSource;

    

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        Singleton();
    }

    // Start is called before the first frame update
    void Start()
    {
        

    }

    void Singleton()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(instance); //sahneler aras� ge�i�te her sahnede m�zik �alcak
        }

    }

    public void MuzikCal(bool play)
    {
        if (play)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    

    
}
