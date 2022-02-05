using System.Collections;
using System.Collections.Generic;
using UnityEngine;
////Force on Gun2 bullet
public class Gun2Movement : MonoBehaviour
{
    private Rigidbody Gun2Rb;
    private float force = 40f;
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
    //bullet destroy
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
