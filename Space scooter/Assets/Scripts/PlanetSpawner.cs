using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSpawner : MonoBehaviour
{
    public GameObject Gplanet, Rplanet, Bplanet;
    float randx;
    Vector2 whereToSpawn;
    float whatToSpawn;
    public float planetRate = 0f;
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
        nextSpawn = planetRate;
        randx = Random.Range(-13f,13f);
        whatToSpawn = Random.Range(1,4);
        if(whatToSpawn == 1){
            whereToSpawn = new Vector2(randx, transform.position.y);
            Instantiate(Gplanet, whereToSpawn, Quaternion.identity);
            } else if (whatToSpawn == 2) {
            whereToSpawn = new Vector2(randx, transform.position.y);
            Instantiate(Rplanet, whereToSpawn, Quaternion.identity);
            }else if (whatToSpawn == 3) {
            whereToSpawn = new Vector2(randx, transform.position.y);
            Instantiate(Bplanet, whereToSpawn, Quaternion.identity);
            }
        } 
    }
}
