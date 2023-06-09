using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBullet : MonoBehaviour
{
    public float projectileSpeed;
    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = -transform.up * projectileSpeed;
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Red")
        {
            Destroy(collision.gameObject);

        }
        else
        {
            Destroy(gameObject);
        }
        Debug.Log("Hit");
    }

}
