using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NicknameFollowCameraScript : MonoBehaviour
{
    private Transform camera1;
    void Start()
    {
        camera1 = Camera.main.transform;
    }
    void Update()
    {
        transform.LookAt(transform.position + camera1.rotation * Vector3.forward, camera1.rotation * Vector3.up);
    }
}
