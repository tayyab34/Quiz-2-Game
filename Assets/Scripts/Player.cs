using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    public GameObject[] Fires;
    public GameObject[] Guns;
    private int damage = 10;
    private bool isgun0=true;
    private bool isgun1 = false;
    private bool isgun2 = false;
    public int enemykill = 0;
    private float speed = 5f;
    int health = 100;
    private Rigidbody playerRb;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        StartCoroutine(Timer());
    }
    void Update()
    {
        //player Movement
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        //Gun Changing
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Guns[0].SetActive(true);
            Guns[1].SetActive(false);
            Guns[2].SetActive(false);
            isgun0 = true;
            isgun1 = false;
            isgun2 = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Guns[0].SetActive(false);
            Guns[1].SetActive(true);
            Guns[2].SetActive(false);
            isgun1 = true;
            isgun2 = false;
            isgun0 = false;
            //Instantiate(Fires[1], transform.position, Guns[1].transform.rotation);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Guns[0].SetActive(false);
            Guns[1].SetActive(false);
            Guns[2].SetActive(true);
            isgun2 = true;
            isgun0 = false;
            isgun1 = false;
            //Instantiate(Fires[2], transform.position, Guns[2].transform.rotation);
        }
        //Gun Fires
        if (Input.GetKeyDown(KeyCode.Space) && isgun0==true )
        {
            Instantiate(Fires[0], Guns[0].transform.position + new Vector3(0, 0, 1), Fires[0].transform.rotation);
        }
        else if (Input.GetKeyDown(KeyCode.Space) && isgun1 == true)
        {
            Instantiate(Fires[1], Guns[1].transform.position + new Vector3(0, 0, 1), Fires[1].transform.rotation);
        }
        else if (Input.GetKeyDown(KeyCode.Space) && isgun2 == true)
        {
            Instantiate(Fires[2], Guns[2].transform.position + new Vector3(0, 0, 1), Fires[2].transform.rotation);
        }
    }
    //Destroy enemy when hit player
    //Player destroy when health is 0
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            health -= damage;
            if (health < 1)
            {
                Destroy(gameObject);
            }
        }
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(60);
        if (enemykill >= 15)
        {
            Debug.Log("Player Win");
        }
        else
        {
            Debug.Log("Player Lose");
        }
    }
}
