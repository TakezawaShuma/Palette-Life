using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -1.0f, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, 0.2f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 1.0f, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -0.2f);
        }

        if (Input.GetKey(KeyCode.A) & Input.GetKey(KeyCode.W))         // 同時に押されたら 上
        {
            transform.Rotate(0, -0.1f, 0);
            transform.Translate(0, 0, 0.01f);
        }
        if (Input.GetKey(KeyCode.D) & Input.GetKey(KeyCode.W))
        {
            transform.Rotate(0, 0.1f, 0);
            transform.Translate(0, 0.01f, 0);
        }

        if (Input.GetKey(KeyCode.A) & Input.GetKey(KeyCode.S))      // 下
        {
            transform.Rotate(0, -0.1f, 0);
            transform.Translate(0, 0, -0.01f);
        }
        if (Input.GetKey(KeyCode.D) & Input.GetKey(KeyCode.S))      // 下
        {
            transform.Rotate(0, 0.1f, 0);
            transform.Translate(0, -0.01f, 0);
        }
    }
}
