using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    [SerializeField] AudioClip[] ukeChords;
    [SerializeField] AudioSource audioSource;
    [SerializeField] float playInterval;
    // Start is called before the first frame update
    void Start()
    {
        CallAudio();
    }

    void PlayRandomChord()
    {
        audioSource.clip = ukeChords[Random.Range(0, ukeChords.Length)];
        audioSource.Play();
        CallAudio();
    }

    void CallAudio()
    {
        Invoke("PlayRandomChord", playInterval);
    }
}
