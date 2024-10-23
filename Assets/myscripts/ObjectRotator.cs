using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectRotator : MonoBehaviour
{
    // Rotation axis (default is up)
    public Vector3 rotationAxis = Vector3.up;
    // Degrees per second
    public float rotationSpeed = 50f; 

    void Update()
    {
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);
    }
}
