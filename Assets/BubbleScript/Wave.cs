using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    Rigidbody2D rb ;
    public float BubbleSpeed = 5;
    public float WaveRange = 3;
    public float WaveSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {   
        if(transform.position.y == WaveRange)
        {
            Vector3 movement = new Vector3(-1 * BubbleSpeed, -1*WaveSpeed,0f);
            rb.velocity = movement;
        }
        else if(-1*transform.position.y == -1* WaveRange)
        {

            Vector3 movement = new Vector3(-1 * BubbleSpeed, WaveSpeed,0f);
            rb.velocity = movement;
        }
    }
}

