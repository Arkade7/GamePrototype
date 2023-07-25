using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GOBehaviour : MonoBehaviour
{
    [SerializeField] BlueSlider BlueSlider;
    [SerializeField] RedSlider RedSlider;
    public float GO_speed = 5;
    private void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.gameObject.tag == "BlueBubble")
        {
            if (GameManager.gameManager.BlueSlider.getBarCurrentValue() < 10)
            {
            BlueSlider.SetCurrentBar(GameManager.gameManager.BlueSlider.setBarCurrentValue(GameManager.gameManager.BlueSlider.getBarCurrentValue()+1)); 
            }
            
        }
        else if (collision.gameObject.tag == "RedBubble")
        {
            if (GameManager.gameManager.RedSlider.getBarCurrentValue() > 0)
            {
            RedSlider.SetCurrentBar(GameManager.gameManager.RedSlider.setBarCurrentValue(GameManager.gameManager.RedSlider.getBarCurrentValue()-1));
            }
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal"); // Get input from left/right arrow keys
        float vertical = Input.GetAxisRaw("Vertical"); // Get input from up/down arrow keys

        Vector3 movement = new Vector3(horizontal, vertical,0f); // Create a movement vector from input
        transform.position = transform.position + movement.normalized * GO_speed * Time.deltaTime; // Move object
    }
}


