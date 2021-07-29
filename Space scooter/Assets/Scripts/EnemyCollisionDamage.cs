using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisionDamage : MonoBehaviour
{
    public int health = 1;
public GameObject eDeathPrefab;
public Animator animator;
public AudioSource eDiesSound;

    void Start() {
        
    }

    /*void OnCollisionEnter2D() {
        Debug.Log("Collision!");
    }*/
    void OnTriggerEnter2D() {
        
        health--;
    }
    void Update() {
        

        if(health <= 0){
            Die();
            animator.SetBool("Dead", true);
            Instantiate(eDeathPrefab, transform.position, transform.rotation);
            Instantiate(eDiesSound, transform.position, transform.rotation);
        }
    }
    void Die(){
        Destroy(gameObject);
        Points.instance.AddPoint();
    }

    

}
