using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    GameObject lookAtPoint;
    // Start is called before the first frame update
    void Start()
    {
        lookAtPoint = GameObject.Find("/Player/LookAtPoint");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(lookAtPoint.transform);
    }
}
