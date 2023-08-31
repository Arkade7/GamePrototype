using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleBehaviour : MonoBehaviour
{
    void Update()
    {
        //Vector3 movement = new Vector3(BubbleSpeed,0f,0f);
        //transform.position = transform.position + movement * Time.deltaTime;
    }
    private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "GullyOpal")
        {
           Destroy(gameObject);
        }
    }
}


