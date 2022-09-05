using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    float walkRange = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveSpeed = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * moveSpeed * speed * Time.deltaTime);
        if (transform.position.x > walkRange )
        {
            transform.position = new Vector3(20,transform.position.y,transform.position.z);
        }
        if (transform.position.x < -walkRange)
        {
            transform.position = new Vector3(-20, transform.position.y, transform.position.z);
        }
    }
}
