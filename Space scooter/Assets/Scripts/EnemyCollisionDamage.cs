using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Add to sun whenu wake up dumbass
public class EnemyCollisionDamage : MonoBehaviour
{
    public int health = 1;
    //public float invulnPeriod = 0f;
    //float invulnTimer = 0;
    int correctLayer;

    void Start() {
        correctLayer = gameObject.layer;
    }

    /*void OnCollisionEnter2D() {
        Debug.Log("Collision!");
    }*/
    void OnTriggerEnter2D() {
        
        health--;
        //invulnTimer = invulnPeriod;
        //gameObject.layer = 10;
    }
    void Update() {
        
        /*invulnTimer -=Time.deltaTime;
        if(invulnTimer <= 0){
            gameObject.layer = correctLayer;
        }*/

        if(health <= 0){
            Die();
        }
    }
    void Die(){
        Destroy(gameObject);
        Points.instance.AddPoint();
    }

    

}
