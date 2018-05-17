using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{

    public bool makeFlag;

    // Use this for initialization
    void Start()
    {
        makeFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        Renderer obj;
        obj = GetComponent<Renderer>();

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;

            obj.material.color = Color.gray;
        }

        if (obj.material.color == Color.gray)
        {
            makeFlag = true;
        }
    }
}