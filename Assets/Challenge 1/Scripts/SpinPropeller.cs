using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    // Start is called before the first frame update
    private float rotationSpeed = 900.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
