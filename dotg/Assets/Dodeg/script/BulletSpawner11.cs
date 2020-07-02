﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner11 : MonoBehaviour
{
    public GameObject Bullet;

    public float  speed=10;
    public float Timer = 1;
    public float timer = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;

        if(Timer <= 0)
        {
            GameObject bullet = GameObject.Instantiate(Bullet);
            bullet.transform.position = transform.position;
            bullet.transform.rotation = transform.rotation;
            Timer = timer;
        }
        transform.Rotate(0, speed, 0);
    }
}
