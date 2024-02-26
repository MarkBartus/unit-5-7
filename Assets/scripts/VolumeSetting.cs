using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSetting : MonoBehaviour
{
    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider sfxSlider;
    [SerializeField] private Slider masSlider;
    
    
    public void muteToggle(bool muted)
    {
        if ( muted)
        {
            myMixer.SetFloat("Music", -80);
        }
        else
        {
            myMixer.SetFloat("Music", 0);
        }
    }
    private void Start()
    {
        if (PlayerPrefs.HasKey("masVolume"))
        {
            LoadVolume1();
        }
        else
        {
            SetMasVolume();
        }
        if (PlayerPrefs.HasKey("sfxVolume"))
        {
            LoadVolume();
        }
        else
        {
            SetSfxVolume();
        }
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            LoadVolume();
        }
        else
        {
            SetMusicVolume();
        }


        SetMusicVolume();
    }
    public void SetMasVolume()
    {
        float volume = masSlider.value;
        myMixer.SetFloat("Master", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("masVolume", volume);
    }



    public void SetSfxVolume()
    {
        float volume = sfxSlider.value;
        myMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("sfxVolume", volume);
    }
    public void SetMusicVolume()
    {
        float volume = musicSlider.value;
        myMixer.SetFloat("Music", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("musicVolume", volume);
    }
    private void LoadVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
        SetMusicVolume();
        sfxSlider.value = PlayerPrefs.GetFloat("sfxVolume");
        SetSfxVolume();

    }
    private void LoadVolume1()
    {
        masSlider.value = PlayerPrefs.GetFloat("masVolume"); 
        SetMasVolume();
        
    }
}
