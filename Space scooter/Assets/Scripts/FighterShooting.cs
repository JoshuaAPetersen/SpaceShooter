using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    int bulletLayer; 
    public float fireDelay = 0.50f;
    float cooldownTimer = 0;
    public AudioSource shootSound;
    Transform player;
    
    void Start() {
        bulletLayer = gameObject.layer;
    }

    // Update is called once per frame
    void Update()
    {

         if(player == null)
        {
            GameObject go = GameObject.Find("Player");
            if(go != null)
            {
                player = go.transform;
            }
        }

        cooldownTimer -= Time.deltaTime;
        if( cooldownTimer <= 0 && Vector3.Distance(transform.position, player.position) < 3){
            //shootSound.Play();
            cooldownTimer = fireDelay;
            GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, transform.position, transform.rotation);
            bulletGO.layer = bulletLayer;
            Instantiate(shootSound, transform.position, transform.rotation);
        }
    }
}
