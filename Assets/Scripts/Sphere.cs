using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour, IWalking
{
    public void Start()
    {
        InvokeRepeating(nameof(Walk), 2F, 2F);
    }

    public void Walk()
    {
        print("Sphere.Walk");
        transform.position = Vector3.up * 2;
    }
}