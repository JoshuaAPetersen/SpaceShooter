using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    public int health = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }
void OnTriggerEnter2D() {
        
        health--;
    }
    // Update is called once per frame
    void Update()
    {
        if(health <= 0){
            Die();
        }
    }
    void Die(){
        Destroy(gameObject);
    }
}
