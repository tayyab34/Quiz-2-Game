using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Force on Gun1
public class Gun1Movement : MonoBehaviour
{
    private Gun1 Gun1;
    private Rigidbody Gun1Rb;
    private float force=100f;
    // Start is called before the first frame update
    void Start()
    {
        Gun1Rb = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {

        Gun1Rb.AddForce(force * Vector3.forward);
    }
}
