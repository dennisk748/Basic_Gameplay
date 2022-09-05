using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AnimalController : MonoBehaviour, IAnimalHit
{
    public float speed;
    private float outerRange = -13f;
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (transform.position.z < outerRange)
        {
            Destroy(gameObject);
        }
        
        bool spaceClick = Input.GetKeyDown(KeyCode.Space);
        if (spaceClick)
        {
            speed = 0f;
            animator.SetFloat("Speed_f", 0f);
            animator.SetBool("Eat_b", true);
        }
    }
    public void AnimalHit()
    {
        speed = 0f;
        animator.SetFloat("Speed_f", 0f);
        animator.SetBool("Eat_b",true);
    }
}
