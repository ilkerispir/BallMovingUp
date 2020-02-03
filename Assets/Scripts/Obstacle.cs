using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int RotationSpeed;

    void Update()
    {
        if (RotationSpeed != 0)
        {
            Rotation();
        }
    }

    void Rotation()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * RotationSpeed);
    }
}
