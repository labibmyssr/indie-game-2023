using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ControlerPemain : MonoBehaviour
{

    public float kecepatan;
    private bool bergerak;
    private Vector2 input;

    private void Update()
    {
        if (!bergerak)
        {
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");

            if (input != Vector2.zero)
            {
                var posisiTarget = transform.position;
                posisiTarget.x += input.x;
                posisiTarget.y += input.y;

                StartCoroutine(Gerak(posisiTarget));

            }

        }


    }

    IEnumerator Gerak(Vector3 posisiTarget)
    {
        bergerak = true;
        while((posisiTarget - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            posisiTarget = Vector3.MoveTowards(transform.position, posisiTarget, kecepatan * Time.deltaTime);
            
            yield return null; 
        }

        transform.position = posisiTarget;
        bergerak = false;
    }
}
