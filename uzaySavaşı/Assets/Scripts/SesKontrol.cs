using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesKontrol : MonoBehaviour
{
    [SerializeField]
    AudioClip asteroidPatlama;

    [SerializeField]
    AudioClip gemiPatlama;

    [SerializeField]
    AudioClip ates;

    AudioSource audioSource;




    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void AsteroidPatlama()
    {
        audioSource.PlayOneShot(asteroidPatlama, 0.4f);
    }

    public void GemiPatlama()
    {
        audioSource.PlayOneShot(gemiPatlama);
    }

    public void Ates()
    {
        audioSource.PlayOneShot(ates, 0.3f);
    }
}
