using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MoveToPlayer : MonoBehaviour
{
    public GameObject player;
    private int moveSpeed;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
        moveSpeed = Random.Range(1, 5);
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.Find("strawberry");
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.deltaTime);

        if(player.transform.position.x < transform.position.x)
        {
            Debug.Log("Moving LEFt");
        }
        else if (player.transform.position.x > transform.position.x)
        {
            Debug.Log("Moving Right");
        }

        if (player.transform.position.y < transform.position.y)
        {
            Debug.Log("Moving Down");
        }
        else if (player.transform.position.y > transform.position.y)
        {
            Debug.Log("Moving Up");
        }

    }
}
