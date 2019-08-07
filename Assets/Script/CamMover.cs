using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMover : MonoBehaviour {
    [SerializeField]
    Vector3[] pos;
    Vector3 InitPos;
    Transform cam;
    Camera camera;
	// Use this for initialization
	void Start () {
        cam = this.transform;
        InitPos = transform.position;
        camera = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            cam.transform.position = InitPos;
            camera.fieldOfView = 55;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            cam.transform.position = pos[0];
            camera.fieldOfView = 17;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            cam.transform.position = pos[1];
            camera.fieldOfView = 17;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            cam.transform.position = pos[2];
            camera.fieldOfView = 17;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            cam.transform.position = pos[3];
            camera.fieldOfView = 17;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            cam.transform.position = pos[4];
            camera.fieldOfView = 17;
        }
        else if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            cam.transform.position = pos[5];
            camera.fieldOfView = 17;
        }
    }
}
