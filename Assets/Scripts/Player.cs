using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    public GameObject[] Guns;
    private Gun1 Gun1;
    private Gun2 Gun2;
    private Gun3 Gun3;
    private int damage;
    private Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }
    //Gun Instantiation
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Instantiate(Guns[0], transform.position, Guns[0].transform.rotation);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Instantiate(Guns[1], transform.position, Guns[1].transform.rotation);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Instantiate(Guns[2], transform.position, Guns[2].transform.rotation);
        }
    }
    //Destroy enemy when hit player
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
    }
}
