using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnCollision : MonoBehaviour
{
    public AudioSource objectAudio;
    public bool isPlaying;

    // Start is called before the first frame update
    void Start()
    {
        objectAudio = GetComponent<AudioSource>();
        isPlaying = false;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //objectAudio.loop = true;
            objectAudio.Play();
        }
    }
}
