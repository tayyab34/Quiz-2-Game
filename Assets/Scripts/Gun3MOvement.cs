using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Force on Gun3 bullet
public class Gun3MOvement : MonoBehaviour
{
    private Rigidbody Gun3Rb;
    private float force = 30f;
    // Start is called before the first frame update
    void Start()
    {
        Gun3Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Gun3Rb.AddForce(force * Vector3.forward);
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
