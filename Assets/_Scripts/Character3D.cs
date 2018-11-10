using System;
using System.Collections.Generic;
using UnityEngine;
using Core.SystemControls;

public abstract class Character3D : MonoBehaviour
{
    [SerializeField]
    protected float moveSpeed;

    [SerializeField]
    protected float rotationSpeed;

    private void Update()
    {
        Movement();
    }

    protected virtual void Movement()
    {
        SystemControls.Movement(transform, moveSpeed, rotationSpeed);
    }
}

