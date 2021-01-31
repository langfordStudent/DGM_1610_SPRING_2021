using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
  // Access Modifier, Data Type, Name
  private float speed = 30.0f;
  private float turnspeed = 35.0f;
  private float hInput;
  private float fInput;
    // Update is called once per frame
    void Update()
    {
      hInput = Input.GetAxis("Horizontal");
      fInput = Input.GetAxis("Vertical");
      transform.Translate(Vector3.forward * Time.deltaTime * speed * fInput); 
      transform.Rotate(Vector3.up, turnSpeed * hInput * Time.deltaTime); 
    }
}