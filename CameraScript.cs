using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public GameObject Cat;


    private Vector3 offset;

    void Start()
    {
        offset = transform.position - Cat.transform.position;
    }

    void LateUpdate()
    {
        transform.position = Cat.transform.position + offset;
    }
}
