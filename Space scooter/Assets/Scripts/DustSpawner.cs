using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustSpawner : MonoBehaviour
{
    public GameObject dust;
    float randx;
    Vector2 whereToSpawn;
    public float dustRate = 0f;
    float nextSpawn = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nextSpawn -= Time.deltaTime;
        if(nextSpawn <= 0){
        nextSpawn = dustRate;
        randx = Random.Range(-13f,13f);
        whereToSpawn = new Vector2(randx, transform.position.y);
        Instantiate(dust, whereToSpawn, Quaternion.identity);
        }
    }
}
