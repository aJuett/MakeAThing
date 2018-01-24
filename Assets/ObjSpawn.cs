using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjSpawn : MonoBehaviour {


    public GameObject Heart;
    public AudioSource Blip;

    void Start()
    {
        InvokeRepeating("HeartSpawn", 1, 2); //1st one is how long itll take before it starts spawing things in, the second one is how often it will spawn
    }

    void HeartSpawn()
    {
        transform.position = new Vector3(-0.87f, -12.89f, 16.78f);
        Instantiate(Heart, transform.position, Quaternion.identity);
        Blip.Play();
    }

    
}

