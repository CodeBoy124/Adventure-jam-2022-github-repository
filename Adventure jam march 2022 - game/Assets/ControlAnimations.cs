using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAnimations : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("Speed", Mathf.Round(Mathf.Abs(Input.GetAxis("Horizontal"))));

        if(Input.GetKeyDown(KeyCode.Space)){
            anim.SetTrigger("Jump");
        }

        if (Input.GetMouseButtonDown(0)){
            anim.SetTrigger("Attack");
        }
    }
}