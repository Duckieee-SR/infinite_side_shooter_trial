using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float _speed = 3;
    private Rigidbody2D rb;
    private int _health = 3;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(-1 * _speed,0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _health = _health - 1;
        if (_health == 0)
            Destroy(gameObject);
    }
}
