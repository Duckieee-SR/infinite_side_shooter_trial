using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public float attackCooldown = 0.5f;
    private bool cool = true;
    private float _shoot;
    public GameObject _bullet;
    public Transform _gun;
    public float _shootSpeed = 0.5f;

    void FixedUpdate()
    {
        _shoot = Input.GetAxisRaw("Fire1");
        BulletManager();
    }

    void BulletManager()
    {
        if (_shoot == 1 && cool == true)
        {
            Instantiate(_bullet, _gun);
            StartCoroutine(CooldownCoroutine());
        }
    }
    IEnumerator CooldownCoroutine()
    {
        cool = false;
        yield return new WaitForSeconds(attackCooldown);
        cool = true;
    }
}
