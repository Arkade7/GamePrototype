using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Straight : MonoBehaviour
{
    public float BubbleSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(BubbleSpeed,0f,0f); // Create a movement vector from input
        transform.position = transform.position + movement * Time.deltaTime; // Move 
    }
}
