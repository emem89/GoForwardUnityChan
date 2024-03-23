using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEControlller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //tag取得
        if (collision.gameObject.tag == "UnityChanTag")
        {
            Debug.Log("unitychan");
        }
        if (collision.gameObject.tag == "GroundTag")
        {
            Debug.Log("ground");
            GetComponent<AudioSource>().Play(); // SE
        }
        if (collision.gameObject.tag == "BlockTag")
        {
            Debug.Log("cube");
            GetComponent<AudioSource>().Play(); // SE
        }
    }
}
