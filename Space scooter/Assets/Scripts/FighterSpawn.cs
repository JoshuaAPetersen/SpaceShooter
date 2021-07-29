using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterSpawn : MonoBehaviour
{
    public GameObject fighterPrefab;

    float spawnDis = 20f;
    float fighterRate = 5f;
    float nextFighter = 1f;

    // Update is called once per frame
    void Update()
    {
        nextFighter -= Time.deltaTime;
        if(nextFighter <= 0) {
            nextFighter = fighterRate;
            fighterRate *= 0.95f;
            Vector3 offset = Random.onUnitSphere;
            offset.z = 0;
            offset = offset.normalized * spawnDis;
            Instantiate(fighterPrefab, transform.position + offset, Quaternion.identity);
        }
    }
}
