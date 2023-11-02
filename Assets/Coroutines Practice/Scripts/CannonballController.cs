using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonballController : MonoBehaviour
{
    

    //variables
    public Rigidbody rb;
    public float upForce;
    public float forwardForce;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * upForce + Vector3.forward * forwardForce, ForceMode.Impulse);
    }
}
