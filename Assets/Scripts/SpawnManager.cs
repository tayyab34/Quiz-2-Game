using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float xRange=3;
    private float zrange=7;
    public GameObject enemyprefab;
    private float StartDelay = 1;
    private float delay = 4;
    // Start is called before the first frame update
    void Start()
    {
        //Repeat enemies
        InvokeRepeating("Spawn", StartDelay,delay);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    //spawning enemy
    private void Spawn()
    {
        Vector3 position = new Vector3(Random.Range(-xRange, xRange), transform.position.y+0.84f, zrange);
        Instantiate(enemyprefab, position, enemyprefab.transform.rotation);
    }
}
