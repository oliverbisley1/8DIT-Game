using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loicSounds : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClipArray;

    void Start()
    {
        audioSource.PlayOneShot(RandomClip());
    }

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    AudioClip RandomClip()
    {
        return audioClipArray[Random.Range(0, audioClipArray.Length - 1)];
    }
}