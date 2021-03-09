using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float rotateSpeed = 1.0f;
    public float moveSpeed = 1.0f;
    private CharacterController _characterController;

    public float gravityAmount = 10;
    public float gravityAcceleration = 0.01f;
    private float gravityFactor = 1;
    
    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (!_characterController.isGrounded)
        {
            _characterController.Move(new Vector3(0,-1,0) * (Time.deltaTime * gravityAmount * gravityFactor));
            gravityFactor += gravityAcceleration;
        }
        else
        {
            gravityFactor = 1f;
        }
        
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0,-1,0) * (rotateSpeed * Time.deltaTime));
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0,1,0) * (rotateSpeed * Time.deltaTime));
        }
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 motion = transform.forward * (moveSpeed * Time.deltaTime);
            _characterController.Move(motion);
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 motion = -transform.forward * (moveSpeed * Time.deltaTime);
            _characterController.Move(motion);
        }
    }

  
}
