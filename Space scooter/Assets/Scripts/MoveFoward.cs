using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFoward : MonoBehaviour
{
    public float moveSpeed = 5f;
    // Update is called once per frame
    void Update()
    {
        Vector3 posit = transform.position;
        
        Vector3 velocity = new Vector3( 0, moveSpeed * Time.deltaTime, 0);

        posit += transform.rotation * velocity;

        transform.position = posit;
    }
}
