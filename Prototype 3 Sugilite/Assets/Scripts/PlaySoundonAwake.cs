using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class PlaySoundonAwake : MonoBehaviour
{
    public AudioSource objectAudio;
    public bool isPlaying;
    
    void Start()
    {
        objectAudio = GetComponent<AudioSource>();
        isPlaying = false;
        Debug.Log("Audio Output: " + objectAudio);

    }

    // Update is called once per frame
    void Update()
    {
        if (!isPlaying)
        {
            isPlaying = true;
            objectAudio.loop = true;
            objectAudio.Play();
            if (objectAudio == null)
            {
                Debug.LogError("sound is null on " + gameObject.name);
            }
        }
    }
}
