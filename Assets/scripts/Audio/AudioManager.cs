using UnityEngine.Audio;
using UnityEngine;
using System;
using Unity.VisualScripting;

public class AudioManager : MonoBehaviour
{

    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;
    [SerializeField] AudioSource playSource;

    public AudioClip menu;
    public AudioClip Button;
    public AudioClip playS;

    private void Start()
    {
        {
            musicSource.clip = menu;
            musicSource.Play();
        }
    }
    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
    public void Playplay(AudioClip clip)
    {
        playSource.PlayOneShot(clip);
    }

}