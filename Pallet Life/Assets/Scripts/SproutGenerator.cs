using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SproutGenerator : MonoBehaviour {

    public GameObject sproutPrefab;

	// Use this for initialization
	void Start () {
		
    }
	
	// Update is called once per frame
	void Update () {

	}

    void OnCollisionEnter(Collision other)
    {
            GameObject sprout = Instantiate(sproutPrefab) as GameObject;
            sprout.transform.position = new Vector3(1.6f, 0.7f, 10);
    }
}
