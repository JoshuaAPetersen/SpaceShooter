using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    int bulletLayer;
    public float fireDelay = 0.25f;
    float cooldownTimer = 0;
    public AudioSource shootSound;

    void Start() {
        bulletLayer = gameObject.layer;
    }

    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;
        if(Input.GetButton("Fire1") && cooldownTimer <= 0){
            //shootSound.Play();
            cooldownTimer = fireDelay;
            GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, transform.position, transform.rotation);
            bulletGO.layer = bulletLayer;
            Instantiate(shootSound, transform.position, transform.rotation);
        }
    }
}
