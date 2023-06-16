using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicMovement : MonoBehaviour
{
    [SerializeField]
    private int speed = 2;
    [SerializeField]
    Rigidbody rb;
    float lastTime;


    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        /*if (Time.time > lastTime + 2)
        {
            Debug.Log("Horizontal " + horiMov + "Vertical " + vertMov);
            lastTime = Time.time;
        }*/
    }
    private void FixedUpdate()
    {
        float horiMov = Input.GetAxis("Horizontal") * speed;
        float vertMov = Input.GetAxis("Vertical") * speed;
        
        Vector3 mov = new Vector3(horiMov * speed, rb.velocity.y, vertMov * speed);
        rb.velocity = Vector3.ClampMagnitude(mov, speed);
           
    }
}
