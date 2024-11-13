using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3.0f;

    public int maxHealth = 5;
    public float timeInvincible = 2;
    public int health { get { return currentHealth; } }
    int currentHealth;

    bool isInvincible;
<<<<<<< HEAD
    float isInvincibleTimer;
=======
    float isInvinvibleTimer;
>>>>>>> 046ceed7591c409e9c122a9766b00678ba967e07

    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;

    Animator animator;
    Vector2 lookDirection = new Vector2(1, 0);
    private float invincibleTimer;
    private int maxhealth;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

<<<<<<< HEAD
        if (isInvincible)
        {
            isInvincibleTimer -= Time.deltaTime;
            if (isInvincibleTimer < 0)
=======
        Vector2 move = new Vector2(horizontal, vertical);

        if (!Mathf.Approximately(move.x, 0.0f) || !Mathf.Approximately(move.y, 0.0f))
        {
            lookDirection.Set(move.x, move.y);
            lookDirection.Normalize();

        }
        animator.SetFloat("Look X", lookDirection.x);
        animator.SetFloat("Look Y", lookDirection.y);
        animator.SetFloat("Speed", move.magnitude);

        if (isInvincible)
        {
            invincibleTimer -= Time.deltaTime;
            if (invincibleTimer < 0)
>>>>>>> 046ceed7591c409e9c122a9766b00678ba967e07
            {
                isInvincible = false;
            }
        }
<<<<<<< HEAD
=======

>>>>>>> 046ceed7591c409e9c122a9766b00678ba967e07
    }
    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
<<<<<<< HEAD
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime; ;
=======
        position.x = position.x + speed * Time.deltaTime * horizontal;
        position.y = position.y + speed * Time.deltaTime * vertical; 
>>>>>>> 046ceed7591c409e9c122a9766b00678ba967e07

        rigidbody2d.MovePosition(position);
    }
    public void ChangeHealth(int amount)
    {
<<<<<<< HEAD
        if(amount < 0 )
        {
            if(isInvincible)
=======
        if (amount < 0)
        {
            animator.SetTrigger("Hit");

            if (isInvincible)
>>>>>>> 046ceed7591c409e9c122a9766b00678ba967e07
            {
                return;
            }
            isInvincible = true;
<<<<<<< HEAD
            isInvincibleTimer = timeInvincible;
        }
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
=======
            invincibleTimer = timeInvincible;
        }
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxhealth);
>>>>>>> 046ceed7591c409e9c122a9766b00678ba967e07
        Debug.Log(currentHealth + "/" + maxHealth);
    }
}