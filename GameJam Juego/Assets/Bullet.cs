using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed; 
    }

    void OnTrigger2D (Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
