using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SproutGenerator : MonoBehaviour {

    public GameObject sproutPrefab;

    bool flag = false;

    // Use this for initialization
    void Start () {
		
    }
	
	// Update is called once per frame
	void Update () {

	}

    void OnCollisionEnter(Collision other)
    {
        if(flag==false)
        {
            GameObject sprout = Instantiate(sproutPrefab) as GameObject;
            sprout.transform.position = new Vector3(1.6f, 0.7f, 10);

            flag = true;
        }
    }
}
