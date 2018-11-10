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

    [SerializeField]
    Transform head;

    private void Start()
    {
        m_PhotonView = GetComponent<PhotonView>();
        m_TransformView = GetComponent<PhotonTransformView>();
        if (m_PhotonView.isMine)
        {
            Camera.main.transform.parent = head.transform;
            Camera.main.transform.localPosition = head.localPosition;
        }
    }

    private void Update()
    {
        if (m_PhotonView.isMine)
        {
            Movement();

            //Camera.main.transform.SetPositionAndRotation(head.position, head.rotation);
            //cam.enabled = true;
        } 
    }

    protected virtual void Movement()
    {
        SystemControls.Movement(transform, moveSpeed, rotationSpeed);
    }
}

