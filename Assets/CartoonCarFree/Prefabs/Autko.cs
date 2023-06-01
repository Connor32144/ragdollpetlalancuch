using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autko : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public float drift;
    public float pitch;
    public float speedOnLoop;
    private bool isLooping;

    public void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        isLooping = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        isLooping = true;
    }
    private void FixedUpdate()
    {
        if (isLooping == false)
        {
            rb.AddForce(speed, 0f, 0f);
        }
        else
        {
            rb.AddForce(speedOnLoop, pitch, drift);
        }
    }
}