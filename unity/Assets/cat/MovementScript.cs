using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class movementScript : MonoBehaviour
{
    float turningSpeed = 90;
    float WalkingSpeed = 550;
    Animator playerAnimator;
    Rigidbody rb;
    float moveX;
    float moveY;


    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerAnimator.SetBool("isWalking", false);
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.W))
        {

            playerAnimator.SetBool("isWalking", true);

        }
        if (Input.GetKey(KeyCode.S))
        {

            playerAnimator.SetBool("isWalking", true);

        }
        if (Input.GetKey(KeyCode.A))
        {


            playerAnimator.SetBool("isWalking", true);

        }
        if (Input.GetKey(KeyCode.D))
        {


            playerAnimator.SetBool("isWalking", true);

        }
        rb.velocity=(transform.forward*moveY)*WalkingSpeed*Time.deltaTime;
        transform.Rotate((transform.up * moveX) * turningSpeed * Time.deltaTime);

    }

}

