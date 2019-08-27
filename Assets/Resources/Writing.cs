using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Writing : MonoBehaviour
{

public GameObject paint;
public GameObject imageTarget;

void Update()
{
       
    if (Input.touchCount > 0)
    {
        imageTarget = GameObject.Find("Board");
        GameObject clone = Instantiate(paint, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation) as GameObject;
        clone.transform.parent = imageTarget.transform;
    }
}


}