﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw_Grenade : MonoBehaviour
{
    public Rigidbody Grenade_Source;
    public int Throw_Y = 2;
    public int Throw_Z = 30;
    public AudioClip Throw_Sound; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Rigidbody Grenade = Instantiate(Grenade_Source, transform.position, transform.rotation);
            Grenade.velocity = transform.TransformDirection(new Vector3(0, Throw_Y, Throw_Z));// 投擲的力量
            GetComponent<AudioSource>().PlayOneShot(Throw_Sound);
        }
    }
}
