using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public Transform Target;
    public float Distance;
    public float Camera_speed = 0.03f;

    private Camera camera;


    void Start()
    {
        if (camera)
            camera = GetComponent<Camera>();
    }

    void Update()
    {
        if(Target)
        {
            transform.position = Vector3.Lerp(transform.position, Target.position, Camera_speed) + new Vector3(0, 0, Distance);
        }
    }
}
