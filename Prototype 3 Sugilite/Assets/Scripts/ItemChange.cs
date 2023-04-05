using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemChange : MonoBehaviour
{
    public GameObject torch;
    public GameObject phone;
    public AudioSource switchOn;
    
    //check if the light source is already torch
    bool isPhone = false;
    
    // Start is called before the first frame update
    void Start()
    {
        torch.SetActive(true);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("ChangeItemTrigger"))
        {
            if (switchOn == null)
            {
                Debug.LogError("switchOn is null on " + gameObject.name);
            }
            
            phone.SetActive(true);
            Destroy(torch);
            if (!isPhone)
            {
                switchOn.PlayOneShot(switchOn.clip);
                isPhone = true;
            }
            
        }
    }
    
}
