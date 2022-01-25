using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    Vector3 rPosition;
    GameObject obj;
    public GameObject chicken;
    float rot;
    // Start is called before the first frame update
    void Start()
    {
        rPosition = transform.position - new Vector3(0, 0, transform.position.normalized.z * transform.localScale.z / 2);
        obj = new GameObject();
        obj.transform.position = transform.position + new Vector3(0, -GetComponent<Renderer>().bounds.size.y / 2, GetComponent<Renderer>().bounds.size.z / 2);
        obj.transform.parent = transform;
        obj.transform.rotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && transform.eulerAngles.x > 290)
            transform.RotateAround(rPosition, Vector3.right, -0.25f);
        else if (Input.GetKey(KeyCode.DownArrow) && transform.eulerAngles.x < 355)
            transform.RotateAround(rPosition, Vector3.right, 0.25f);
        if (Input.GetKeyDown(KeyCode.Space))
            Instantiate(chicken, obj.transform.position, obj.transform.rotation);
    }
}
