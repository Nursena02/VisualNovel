using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MainScript : MonoBehaviour
{


    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();

    }
    public void Geçiş() => animator.SetBool("İsSlide", true);



}
