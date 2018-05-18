using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SproutGenerator : MonoBehaviour {

    public GameObject sproutPrefab;

    int sproutNum = 0;
    int maxSprout = 2;

    // Use this for initialization
    void Start () {
		
    }
	
	// Update is called once per frame
	void Update () {

	}

    void OnCollisionEnter(Collision other)
    {
        if(sproutNum < maxSprout)
        {
            GameObject sprout = Instantiate(sproutPrefab) as GameObject;
            sprout.transform.position = new Vector3(1.6f, 0.7f, 10);

            sproutNum++;

            if (sproutNum == 1)
            {
                GameObject sprouts = Instantiate(sproutPrefab) as GameObject;
                sprouts.transform.position = new Vector3(-1.84f, 0.7f, 10);

                sproutNum++;
            }
        }
    }
}
