using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlerPemain2 : MonoBehaviour
{
    public Rigidbody2D rb;
    public float intensitas;

    Vector2 gerakan = Vector2.zero;

    private void Update()
    {
        float sumbuX = Input.GetAxis("Horizontal");
        float sumbuY = Input.GetAxis("Vertical");

        gerakan = new Vector2(sumbuX, sumbuY).normalized;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(gerakan.x * intensitas, gerakan.y * intensitas);
    }

}
