using UnityEngine.Audio;
using UnityEngine;
using System;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class AudioGame : MonoBehaviour
{

    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;
    [SerializeField] AudioSource playSource;
    [SerializeField] AudioSource musicSource1;
    public AudioClip menu;
    public AudioClip game;
    public AudioClip Button;
    public AudioClip playS;


    private void Start()
    {
        musicSource1.clip = game;
        musicSource1.Play();
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