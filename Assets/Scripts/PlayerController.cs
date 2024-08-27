using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed * Input.GetAxis("Vertical"));
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
        if (transform.position.y < -5f)
        {
            transform.position = new Vector3(0f, 1f, 0f);
            transform.rotation = Quaternion.identity;
        }
    }
}

