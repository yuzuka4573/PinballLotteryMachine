using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour {
    Transform current;
    [SerializeField]
    int speed = 90;
    [SerializeField]
    bool isRandom = false;

    // Use this for initialization
    void Start () {
        current = transform;
        if (isRandom) {
            speed = Random.Range(-200, 200);
        }
	}
	
	// Update is called once per frame
	void Update () {
        current.Rotate(new Vector3(0, 0, speed) * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Keypad9)) {
            speed = Random.Range(-360,360);
        }
	}
}
