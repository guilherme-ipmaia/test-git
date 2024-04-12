using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Animator animator;

    public bool butaoDeLigar;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (butaoDeLigar)
            animator.SetTrigger("Ligar");
        else
            animator.SetTrigger("Desligar");
    }
}
