using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody2D Rigidbody2D;
    // Start is called before the first frame update
    void Awake()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Launch(Vector2 direction, float force)
    {
        Rigidbody2D.AddForce(direction * force); 
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("projectile Collision with " + other.gameObject);
        Destroy(gameObject);
    }
}
