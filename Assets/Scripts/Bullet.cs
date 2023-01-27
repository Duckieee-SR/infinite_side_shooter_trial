using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float _speed = 3;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(1 * _speed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collect)
    {
        Destroy(gameObject); //Destroys itself on touch (including w/ itself...)
    }
}
