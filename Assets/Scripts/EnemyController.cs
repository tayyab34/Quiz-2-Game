using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody EnemyRb;
    private GameObject Player;
    private float speed = 1f;
    private float bound = 5f;
    // Start is called before the first frame update
    void Start()
    {
        EnemyRb.GetComponent<Rigidbody>();
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //Destroy enemy at bound
        if (transform.position.y > -bound)
        {
            Destroy(gameObject);
        }
        Move();
    }
    //follow player
    private void Move()
    {
        Vector3 LookDirection = (Player.transform.position - transform.position).normalized;
        EnemyRb.AddForce(LookDirection * speed);
    }
}
