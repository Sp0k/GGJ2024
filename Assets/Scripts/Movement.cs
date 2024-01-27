using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform Camera;
    private Rigidbody rb;

    public int gravity = 2;
    public int speed = 5;
    public int jumpForce = 10;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Physics.gravity = new Vector3(0, Physics.gravity.y * gravity, 0);
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime);

        if (Input.GetKeyDown("space"))
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);

    }
}
