using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController2D m_Controller;
    [SerializeField] private float HorizontalMove = 0f;
    [SerializeField] private bool jump = false;
    [SerializeField] private float JumpForce = 800f;
    [SerializeField] private Animator animator;

    // Update is called once per frame
    void Update()
    {
        HorizontalMove = Input.GetAxis("Horizontal") * 40f;
        animator.SetFloat("Speed", Mathf.Abs(HorizontalMove));
        if( Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        animator.SetBool("isJumping", jump);
    }

    private void FixedUpdate()
    {
        m_Controller.Move(HorizontalMove * Time.fixedDeltaTime, jump);
        jump = false;
    }

}
