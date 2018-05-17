using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainGenerator : MonoBehaviour
{

    public GameObject rainPrefab;

    ColorChange colorChange = null;
    public bool colorFlag;

    public int dropNum = 0;
    int maxRain = 50;

    float span = 0.1f;
    float delta = 0;

    // Use this for initialization
    void Start()
    {
        colorFlag = false;
        colorChange = this.transform.parent.GetComponent<ColorChange>();
    }

    // Update is called once per frame
    void Update()
    {
        colorFlag = colorChange.makeFlag;

        if (colorFlag == true)
        {
            this.delta += Time.deltaTime;

            if (this.delta > this.span)
            {
                this.delta = 0;

                if (dropNum < maxRain)
                {
                    float px = Random.Range(-0.9f, 1.9f);
                    float pz = Random.Range(9.0f, 11.0f);

                    GameObject rain = Instantiate(rainPrefab) as GameObject;
                    rain.transform.position = new Vector3(px, 4, pz);

                    dropNum++;
                }
            }
        }
    }
}
