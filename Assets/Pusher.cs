using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class Pusher : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    bool press = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            press = true;
    }
    private void FixedUpdate()
    {
        if (press)
        {
            rb.AddForce(0, 10, 0, ForceMode.Impulse);
            press = false;
        }
        else
            rb.velocity = Vector3.zero;
    }
}
