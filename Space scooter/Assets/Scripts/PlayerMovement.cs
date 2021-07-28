using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float maxSpeed = 5f;
    //public float horizontalSpeed = 5f;
    public float rotSpeed = 180f;
    float playerBoundary = 0.5f;

    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // hm (Horizontal Movement)
        /*Vector3 hm = transform.position;
        
        hm.x += Input.GetAxis("Horizontal") * horizontalSpeed * Time.deltaTime;

        transform.position = hm;

        transform.Translate(new Vector3 (Input.GetAxis("Horizontal") * horizontalSpeed * Time.deltaTime, 0, 0));*/

        Quaternion rot = transform.rotation;
        float z = rot.eulerAngles.z;
        z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        rot = Quaternion.Euler( 0, 0, z);
        transform.rotation = rot;

        // vm (Vertical Movement)
        Vector3 pos = transform.position;
        
        Vector3 velocity = new Vector3( 0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0);

        pos += rot * velocity;

        if (pos.y+playerBoundary > Camera.main.orthographicSize){
            pos.y = Camera.main.orthographicSize - playerBoundary;
        }
        if (pos.y-playerBoundary < -Camera.main.orthographicSize){
            pos.y = -Camera.main.orthographicSize + playerBoundary;
        }

        float screenRatio = (float)Screen.width / (float)Screen.height;
        float widthOrtho = Camera.main.orthographicSize * screenRatio;
        
        if (pos.x + playerBoundary > widthOrtho){
            pos.x = widthOrtho - playerBoundary;
        }
        if (pos.x - playerBoundary < - widthOrtho){
            pos.x = - widthOrtho + playerBoundary;
        }

        transform.position = pos;

        // transform.Translate(new Vector3 (0,Input.GetAxis("Vertical") * verticalSpeed * Time.deltaTime,0));

    }
}
