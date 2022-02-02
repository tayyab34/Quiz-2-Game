using System.Collections;
using System.Collections.Generic;
using UnityEngine;
////Force on Gun2
public class Gun2Movement : MonoBehaviour
{
    private Gun2 Gun2;
    private Rigidbody Gun2Rb;
    private float force = 50f;
    // Start is called before the first frame update
    void Start()
    {
        Gun2Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        Gun2Rb.AddForce(force * Vector3.forward);
    }
}
