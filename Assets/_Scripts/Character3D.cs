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

    PhotonTransformView m_TransformView;
    PhotonView m_PhotonView;

    private void Start()
    {
        m_PhotonView = GetComponent<PhotonView>();
        m_TransformView = GetComponent<PhotonTransformView>();
    }

    private void Update()
    {
        if (m_PhotonView.isMine)
        {
            Movement();
        } 
    }

    protected virtual void Movement()
    {
        SystemControls.Movement(transform, moveSpeed, rotationSpeed);
    }
}

