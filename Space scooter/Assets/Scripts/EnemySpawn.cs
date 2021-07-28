using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy1, enemy2, enemy3;
    float randx;
    float randE;
    Vector2 whereToSpawn;
    float whatToSpawn;
    float spawn3 = 10f;
    public float spawnRate = 2f;
    float nextSpawn = 0f;

    // Start is called before the first frame update
    void Start()
    {
    whatToSpawn = Random.Range(1,4);
    }

    // Update is called once per frame
    void Update()
    {
        nextSpawn -= Time.deltaTime;
        spawn3 -= Time.deltaTime;
        if(nextSpawn <= 0){
            nextSpawn = spawnRate;
            randx = Random.Range(-10,10);
            if(whatToSpawn == 1){
            whereToSpawn = new Vector2(randx, transform.position.y);
            Instantiate(enemy1, whereToSpawn, Quaternion.identity);
            whatToSpawn = Random.Range(1,4);
            } else if (whatToSpawn == 2) {
            whereToSpawn = new Vector2(randx, transform.position.y);
            Instantiate(enemy2, whereToSpawn, Quaternion.identity);
            whatToSpawn = Random.Range(1,4);
            }else if(spawn3 <= 0){
            whereToSpawn = new Vector2(randx, transform.position.y);
            Instantiate(enemy3, whereToSpawn, Quaternion.identity);
            whatToSpawn = Random.Range(1,4);
            }
        }
    }
}
