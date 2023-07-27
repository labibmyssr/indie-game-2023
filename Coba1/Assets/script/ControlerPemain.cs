using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ControlerPemain : MonoBehaviour
{

    public float kecepatanGerak = 5f;
    public Rigidbody2D rb;
    Vector2 gerakan;
    public Animator animator;
    private void Update()
    {
        gerakan.x = Input.GetAxisRaw("Horizontal");
        gerakan.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", gerakan.x);
        animator.SetFloat("Vertical", gerakan.y);
        animator.SetFloat("Kecepatan", gerakan.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + gerakan.normalized * kecepatanGerak * Time.fixedDeltaTime);
    }
}
