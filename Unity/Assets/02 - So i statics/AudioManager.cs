using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public AudioClip so1, so2;

    private AudioSource asrc;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        asrc = GetComponent<AudioSource>();
    }

    public void PlaySound1()
    {
        asrc.PlayOneShot(so1);
    }

    public void PlaySound2()
    {
        asrc.PlayOneShot(so2);
    }
}
