using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody EnemyRb;
    private GameObject Player;
    private float speed = 5f;
    private int damage1 = 40;
    private int damage2 = 80;
    private int damage3 = 120;
    private float bound = 5f;
    int health = 100;
    // Start is called before the first frame update
    void Start()
    {
        EnemyRb=GetComponent<Rigidbody>();
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    //follow player
    private void Move()
    {
            Vector3 LookDirection = (Player.transform.position - transform.position).normalized;
            EnemyRb.AddForce(LookDirection * speed);
        
    }
    //Collision of enemy with bullets,player and wall
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Wall"))
        {
            Player.GetComponent<Player>().enemykill++;
            Destroy(gameObject);
        }
        else if(collision.gameObject.CompareTag("Gun1bullet"))
        {
            health -= damage1;
            if (health < 1)
            {
                Player.GetComponent<Player>().enemykill++;
                Destroy(gameObject);
            }
        }
        else if (collision.gameObject.CompareTag("Gun2bullet"))
        {
            health -= damage2;
            if (health < 1)
            {
                Player.GetComponent<Player>().enemykill++;
                Destroy(gameObject);
            }
        }
        else if (collision.gameObject.CompareTag("Gun3bullet"))
        {
            health -= damage3;
            if (health < 1)
            {
                Player.GetComponent<Player>().enemykill++;
                Destroy(gameObject);
            }
        }

    }
   
}
