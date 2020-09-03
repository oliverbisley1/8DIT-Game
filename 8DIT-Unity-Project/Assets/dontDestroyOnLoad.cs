using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroyOnLoad : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClipArray;

    void Start()
    { 
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
