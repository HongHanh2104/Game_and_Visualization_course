using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    public Transform followObject;
    private Vector3 moveTemp;
    public float offsetX = 2;
    public float offsetY = 2;
    // Start is called before the first frame update
    void Start()
    {
        moveTemp = followObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveTemp.y > -3.9)
        {
            moveTemp = followObject.transform.position;
            moveTemp.y += offsetY;
            moveTemp.x += offsetX;
            moveTemp.z = transform.position.z;
            transform.position = moveTemp;
        }
    }
}
