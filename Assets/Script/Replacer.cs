using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replacer : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ball")
        {
            GameObject current = collision.gameObject;
            //position set randomly
            current.transform.position = new Vector2(Random.Range(-8f, 8f), 4.35f);
        }
    }

}
