using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject StartPoint;
    [SerializeField] float torqueAmount=1f;
    [SerializeField] float boostSpeed=30f;
    [SerializeField] float baseSpeed=20f;
    private Rigidbody2D rigidBody2D;
    SurfaceEffector2D surfaceEffector2D;
    void Start()
    {
        transform.position=StartPoint.transform.position;
        rigidBody2D=GetComponent<Rigidbody2D>();
        surfaceEffector2D=FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        RespondToBoost();
    }

    private void RespondToBoost()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            surfaceEffector2D.speed=boostSpeed;
        }
        else{
            surfaceEffector2D.speed=baseSpeed;
        }
    }

    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidBody2D.AddTorque(torqueAmount);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidBody2D.AddTorque((-1) * torqueAmount);
        }
    }
}
