using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{
    public GameControl stop;
    public float speed = 5f;
    private Rigidbody2D rb2d;


    void Start ()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	void Update ()
    {
        if(stop.Stop == false)
        {
            if (Input.GetKey("d"))
            {
                var vel = rb2d.velocity;
                vel.x = speed;
                rb2d.velocity = vel;
            }
            else if (Input.GetKey("a"))
            {
                var vel = rb2d.velocity;
                vel.x = -1 * speed;
                rb2d.velocity = vel;
            }
            else if (!Input.anyKey)
            {
                var vel = rb2d.velocity;
                vel.x = 0.0f;
                rb2d.velocity = vel;
            }
        }
        else if(stop.Stop == true)
        {

        }

    }
}
