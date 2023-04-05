using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemChange : MonoBehaviour
{
    public GameObject torch;
    public GameObject phone;
    //public AudioSource switchOn;
    //public AudioSource switchOff;
    
    // Start is called before the first frame update
    void Start()
    {
            torch.SetActive(true);
            //switchOn = GetComponent<AudioSource>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("ChangeItemTrigger"))
        {
            phone.SetActive(true);
            Destroy(torch);
            //switchOn.Play();
        }
    }
    
}
