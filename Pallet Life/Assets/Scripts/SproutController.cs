using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SproutController : MonoBehaviour {

    public GameObject sproutPrefab;

	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = new Ray();
            RaycastHit hit = new RaycastHit();
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;

            //マウスクリックした場所からRayを飛ばし、オブジェクトがあればtrue 
            if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
            {
                if (hit.collider.gameObject.CompareTag("Sprout"))
                {
                    if(sproutPrefab != null)
                    {
                        Destroy(sproutPrefab);
                    }
                }
            }
        }
    }
}
