using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveManager : MonoBehaviour
{
    public Vector2 target;

    public int moveSpeed = 10;

    public GameObject enemy;
    public Transform Player;


    // Start is called before the first frame update
    void Start()
    {
        //target = transform.position;

        InvokeRepeating("SpawnEnemy", 2.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
/*        if (Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        }

        transform.position = Vector2.MoveTowards(transform.position,target, moveSpeed * Time.deltaTime);*/
    }

    void SpawnEnemy()
    {
        GameObject spawnedEnemy = Instantiate(enemy);
        spawnedEnemy.transform.position = new Vector2(UnityEngine.Random.Range(-10, 10), UnityEngine.Random.Range(-5, 5));
    }
}
