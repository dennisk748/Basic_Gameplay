using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThroughFood : MonoBehaviour
{
    public float speed;
    public float outerRange = 50f;
    Rigidbody body;

    private void Start()
    {
        body = GetComponent<Rigidbody>();   
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if(transform.position.z > outerRange)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        var hit = other.GetComponent<IAnimalHit>();
        if (hit != null)
        {
            speed = 0f;
            body.useGravity = true;
            hit.AnimalHit();
        }
    }
}
