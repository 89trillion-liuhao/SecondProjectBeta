using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update

    //移动速度
    public float speedOfMove = 10.0f;
    //旋转速度
    public float rotateSpeed = 40f;
    private Animator _animator;
    private Rigidbody _rigidbody;

    private float h;
    private float v;
    private bool isGround;
    void Start()
    {
        _animator = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody>();
    }
    

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        //PlayerMoveMethod(h,v);
        ShowRun();
        //PlayerAttackMethod();
    }

    void PlayerMoveMethod(float h , float v)
    {
     if( v > 0) transform.Translate(Vector3.forward * speedOfMove * Time.deltaTime);
     else if(v < 0)
     {
         transform.Translate(-Vector3.forward * speedOfMove * Time.deltaTime);
     }
     if( v != 0.0f) _animator.SetBool("isStop",false);
     else  _animator.SetBool("isStop",true);
     transform.Rotate(Vector3.up * h * rotateSpeed * Time.deltaTime);


    }

    void ShowRun()
    {

        // if (Input.GetKeyDown(KeyCode.A))
        // {
        //     _animator.SetBool("isAttack",true);
        //     
        // }

        if (Input.GetKeyDown(KeyCode.I))
        {
            _animator.SetBool("isStop",true);
            _animator.SetBool("isRun",false);
            _animator.SetBool("isAttack",false);
        }

        else if (Input.GetKeyDown(KeyCode.R))
        {
            _animator.SetBool("isStop",false);
            _animator.SetBool("isRun",true);
            _animator.SetBool("isAttack",false);
          
            
        }
       
    }
    void PlayerAttackMethod()
    {
        
    }
}
