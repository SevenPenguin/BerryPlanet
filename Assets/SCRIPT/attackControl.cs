using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackControl : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("col.gameObject.tag");
        Debug.Log(col.gameObject.tag);
        if (col.gameObject.tag == "Slime")
        {
            Debug.Log("mbn nb nb n");
            Destroy(col.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(destroyBox());
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
