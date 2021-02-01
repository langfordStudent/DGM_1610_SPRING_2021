using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20.0f;
    public float rotationSpeed = 60.0f;
    public float vInput;

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        vInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * -vInput * Time.deltaTime);
    }
}
