using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour {
    public GameObject[] prefabs;
    public int count;
	// Use this for initialization
	void Start () {
        for (int c = 0; c < count; c++) {
            GameObject current = Instantiate(prefabs[c]) as GameObject;
            current.transform.position = new Vector2(Random.Range(-8f, 8f), 4.35f);

        }
	}
	

}
