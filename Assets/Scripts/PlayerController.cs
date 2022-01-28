using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount=1f;
    private Rigidbody2D rigidBody2D;
    void Start()
    {
        rigidBody2D=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)){
            rigidBody2D.AddTorque(torqueAmount);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            rigidBody2D.AddTorque((-1)*torqueAmount);
        }
    }
}
