using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float HorizontalMove = 0f;
    public bool jump = false;

    [SerializeField]
    private float JumpForce = 800f;

    [SerializeField]
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMove = Input.GetAxis("Horizontal") * 40f;
        animator.SetFloat("Speed", Mathf.Abs(HorizontalMove));
        if( Input.GetButtonDown("Jump") && !jump)
        {
            jump = true;
            
        }
    }

    private void FixedUpdate()
    {
        controller.Move(HorizontalMove * Time.fixedDeltaTime, false, jump);
        if (jump)
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.AddForce(new Vector2(0f, JumpForce));
            
        }
        jump = false;

    }
}
