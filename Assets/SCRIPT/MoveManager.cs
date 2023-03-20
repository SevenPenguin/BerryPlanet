using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveManager : MonoBehaviour
{
    public Vector2 target;

    public int moveSpeed = 10;
    private int spawnCount = 5;

    public GameObject enemy;
    public Transform Player;


    // Start is called before the first frame update
    void Start()
    {
        //target = transform.position;

        //InvokeRepeating("SpawnEnemy", 1.0f, 2.0f);
        SpawnEnemy();
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
 
        if (spawnCount > 0)
        {
            spawnCount--;
            GameObject spawnedEnemy = Instantiate(enemy);
            spawnedEnemy.transform.position = new Vector2(UnityEngine.Random.Range(-10, 10), UnityEngine.Random.Range(8, 17));
        }
    }
}
