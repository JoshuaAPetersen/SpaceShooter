using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunCollision : MonoBehaviour
{
    public int sunHealth = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter2D() {
        
        sunHealth--;
    }

    // Update is called once per frame
    void Update()
    {
    if(sunHealth <= 0){
        Die();
    }
    }
    void Die(){
        Destroy(gameObject);
        Points.instance.AddPoint();
        Points.instance.AddPoint();
        Points.instance.AddPoint();
    }

}
