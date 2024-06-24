using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    public Rigidbody rb;
    private Vector2 input;
    public float acceleration;

    // Start is called before the first frame update
    void Start()
    {
        // transform.position = new Vector3(50, 50, 50);
    }

    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(input.x, 0, input.y) * Time.deltaTime * acceleration);
    }
}
