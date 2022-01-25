using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(0,Mathf.Cos((transform.eulerAngles.x-270)*Mathf.PI/180)*1000, Mathf.Sin((transform.eulerAngles.x - 270) * Mathf.PI / 180) * 1000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
