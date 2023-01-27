using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public Transform _enemyPosition1;
    public Transform _enemyPosition2;
    public Transform _enemyPosition3;
    public Transform _enemyPosition4;
    public Transform _enemyPosition5;
    public Transform _enemyPosition6;
    public Transform _enemyPosition7;
    public Transform _enemyPosition8;
    private int _enemySelector;
    private int _spawnSelector;
    public GameObject _enemy1;
    public GameObject _enemy2;
    private GameObject _enemyType;
    [SerializeField] private float _spawnTime = 3f;

    void Start()
    {
        InvokeRepeating("EnemyManager", _spawnTime, _spawnTime);
    }

    void EnemyManager()
    {
        _enemySelector = Random.Range(1, 3);
        if (_enemySelector == 1)
            _enemyType = _enemy1;
        else if (_enemySelector == 2)
            _enemyType = _enemy2;


        _spawnSelector = Random.Range(1, 9);
        if (_spawnSelector == 1)
            Instantiate(_enemyType, _enemyPosition1);
        else if (_spawnSelector == 2)
            Instantiate(_enemyType, _enemyPosition2);
        else if (_spawnSelector == 3)
            Instantiate(_enemyType, _enemyPosition3);
        else if (_spawnSelector == 4)
            Instantiate(_enemyType, _enemyPosition4);
        else if (_spawnSelector == 5)
            Instantiate(_enemyType, _enemyPosition5);
        else if (_spawnSelector == 6)
            Instantiate(_enemyType, _enemyPosition6);
        else if (_spawnSelector == 7)
            Instantiate(_enemyType, _enemyPosition7);
        else if (_spawnSelector == 8)
            Instantiate(_enemyType, _enemyPosition8);
    }
}
