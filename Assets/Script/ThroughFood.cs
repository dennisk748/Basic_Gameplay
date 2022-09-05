using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThroughFood : MonoBehaviour
{
    public float speed;
    public float outerRange = 50f;
    public Collider Collider;
    
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if(transform.position.z > outerRange)
        {
            Destroy(gameObject);
        }
        OnTriggerEnter(Collider);
    }
    private void OnTriggerEnter(Collider other)
    {
        var hit = other.GetComponent<IAnimalHit>();
        if(hit != null)
        {
            hit.AnimalHit();
        }
    }
}
