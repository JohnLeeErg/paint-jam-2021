using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    [SerializeField] AudioClip[] ukeChords;
    [SerializeField] AudioSource audioSource;
    [SerializeField] float playInterval;
    [SerializeField] AudioSource[] interferingAudioSources;
    float defaultVolume;
    // Start is called before the first frame update
    void Start()
    {
        defaultVolume = audioSource.volume;
        CallAudio();
    }

    void PlayRandomChord()
    {
        float vol = defaultVolume;
        foreach(AudioSource eachIsland in interferingAudioSources)
        {
            if (Vector2.Distance(transform.position, eachIsland.transform.position)<eachIsland.maxDistance)
            {
                vol = (Vector2.Distance(transform.position, eachIsland.transform.position) / (eachIsland.maxDistance - eachIsland.minDistance));
            }
        }
        print("uke volume at" + vol);
        audioSource.volume = Mathf.Lerp(0,defaultVolume,vol);
        audioSource.clip = ukeChords[Random.Range(0, ukeChords.Length)];
        audioSource.Play();
        CallAudio();
    }

    void CallAudio()
    {
        Invoke("PlayRandomChord", playInterval);
    }
}
