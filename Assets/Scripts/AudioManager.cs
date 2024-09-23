using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("------------ Audio Source ------------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("------------ Audio Clip ---------------")]
    public AudioClip background;
    public AudioClip death;
    public AudioClip collectingCoins;
    public AudioClip powerUp;
    public AudioClip powerDown;
    public AudioClip invincible;
    public AudioClip checkpoint;
    public AudioClip jump;
    public AudioClip extraLife;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }    
}
