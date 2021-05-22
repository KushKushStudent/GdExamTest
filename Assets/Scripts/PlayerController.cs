using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameManager gm;    public float speed = 1;
    public Rigidbody2D rb;
   
    private Vector3 ForceDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        ForceDirection = transform.right*speed;
    }

    // Update is called once per frame
    void Update()
    {
       rb.AddForce(ForceDirection);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag=="Spikes") 
        {
            gm.Restart();
        
        
        }
        if (collision.transform.tag == "TurnAround")
        {
            if (ForceDirection == transform.right * speed)
            {
                ForceDirection = -transform.right * speed;
            }
            else if (ForceDirection == -transform.right * speed) 
            {
                ForceDirection = transform.right * speed;
            }
        } 
    }
}
