using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("idle", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
