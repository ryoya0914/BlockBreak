using UnityEngine;
using System.Collections;

public class BlockControl : MonoBehaviour
{

	void Start ()
    {
	}
	

	void Update ()
    {
	
	}

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "ball")
        {
            {
                Destroy(transform.gameObject);
            }
        }
    }
}
