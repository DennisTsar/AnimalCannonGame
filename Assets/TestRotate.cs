using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRotate : MonoBehaviour
{
    Vector3 rPosition;
    // Start is called before the first frame update
    void Start()
    {
        rPosition = transform.position - new Vector3(0, 0, transform.localScale.z/2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && transform.eulerAngles.x > 290)
            transform.RotateAround(rPosition, Vector3.right, -1);
        else if (Input.GetKey(KeyCode.DownArrow) && transform.eulerAngles.x < 355)
            transform.RotateAround(rPosition, Vector3.right, 1);
    }
}
