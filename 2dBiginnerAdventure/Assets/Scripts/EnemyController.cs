using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyController : MonoBehaviour
{
    // Public variables
    public float speed = 3.0f;
    public bool vertical;
    public float changeTime = 3.0f;

    // Private variables
    Rigidbody2D rigidbody2d;
    float timer;
    int direction = 1;

    Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        timer = changeTime;
    }

    // Update is called every frame
    void Update()
    {

        timer -= Time.deltaTime;


        if (timer < 0)
        {
            direction = -direction;
            timer = changeTime;
            animator = GetComponent<Animator>();
        }
    }

    // FixedUpdate has the same call rate as the physics system
    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        if (vertical)
        {
            animator.SetFloat("Move X", 0);
            animator.SetFloat("Move Y", direction);
            position.y = position.y + speed * direction * Time.deltaTime;
        }
        else
        {
            animator.SetFloat("Move X", direction);
            animator.SetFloat("Move Y", 0);
            position.x = position.x + speed * direction * Time.deltaTime;
        }


        rigidbody2d.MovePosition(position);
    }
}