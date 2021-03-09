using System;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;
    
    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
       _spriteRenderer.color = Color.green;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        _spriteRenderer.color = Color.white;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Collision") // si je suis en collision avec "Obstacle-Collision" , ( avec le tag "Collision" ) 
        {
            _spriteRenderer.color = Color.red;
        }
    }
    
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Collision") // si je sors de collision avec "Obstacle-Collision" , ( avec le tag "Collision" ) 
        {
            _spriteRenderer.color = Color.white;
        }
    }
}
