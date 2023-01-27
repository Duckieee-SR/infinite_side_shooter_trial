using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Script : MonoBehaviour
{
    public float _speed = 3;
    private Rigidbody2D rb;
    private int _health = 3;
    public GameObject _enemyBullet;
    public Transform _bulletSpawn;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        InvokeRepeating("EnemyShooting", 2f, 2f);
        InvokeRepeating("EnemyShooting", 2.1f, 2f);
        InvokeRepeating("EnemyShooting", 2.2f, 2f);
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(-1 * _speed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _health = _health - 1;
        if (_health == 0)
            Destroy(gameObject);
    }

    void EnemyShooting()
    { 
        Instantiate(_enemyBullet, _bulletSpawn);
    }
}
