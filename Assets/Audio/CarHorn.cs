using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CarHorn : MonoBehaviour
{
    public AudioClip hornSound; // فایل صدای بوق
    private AudioSource audioSource;

    void Start()
    {
        // گرفتن یا اضافه کردن AudioSource به شیء
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = hornSound;
    }

    void Update()
    {
        // بررسی فشار دادن کلید "H"
        if (Input.GetKeyDown(KeyCode.H))
        {
            PlayHorn();
        }
    }

    void PlayHorn()
    {
        // پخش صدای بوق
        if (!audioSource.isPlaying) // اگر صدا در حال پخش نیست
        {
            audioSource.Play();
        }
    }
}


