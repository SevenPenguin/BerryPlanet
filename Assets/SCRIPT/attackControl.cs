using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackControl : MonoBehaviour
{

    public BoxCollider2D attackBox;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Collider2D col = collision.gameObject.GetComponent<Collider2D>();
        Debug.Log(collision.gameObject.tag);
        if (attackBox.IsTouching(col) && collision.gameObject.CompareTag("Slime"))
        {
            Destroy(collision.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        //StartCoroutine(destroyBox());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator destroyBox()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
