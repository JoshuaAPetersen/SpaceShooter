using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHp : MonoBehaviour
{
public float invulnPeriod = 0f;
float invulnTimer = 0;
int correctLayer;
public int maxHealth = 10;
public int currentHealth;

public GameObject deathPrefab;

public HealthBar healthBar;

public Animator animator;
public AudioSource diesSound;
//public GameObject spawner;

    Transform player;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    correctLayer = gameObject.layer;
    healthBar.setMaxHealth(maxHealth);
    }
void OnTriggerEnter2D() {
        
    currentHealth--;
    animator.SetBool("Invuln", true);
    invulnTimer = invulnPeriod;
    gameObject.layer = 10;
}
    // Update is called once per frame
    void Update()
    {
        /*if(player == null)
        {
            GameObject go = GameObject.Find("Player");
            if(go != null)
            {
                player = go.transform;
            }
        }
        if(player == null)
        {
            return;
        }*/
    healthBar.setHealth(currentHealth);
    invulnTimer -= Time.deltaTime;
    if(invulnTimer <= 0){
    gameObject.layer = correctLayer;
    animator.SetBool("Invuln", false);
    }

    if(currentHealth <= 0){
    animator.SetBool("Dead", true);
    diesSound.Play();
    Die();
    Instantiate(deathPrefab, transform.position, transform.rotation);
    }

void Die(){
    Destroy(gameObject);
    Points.instance.GameEnd();
    SceneManager.LoadScene("Dead");
    //spawner.SetActive(false);
    
}
}
    }
