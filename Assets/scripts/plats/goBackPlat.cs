using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goBackPlat : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            anim.SetTrigger("gotHit");
            //inputJump player = collision.;
            collision.rigidbody.AddForce(new Vector2(-250, Random.Range(600, 800)));
        }
    }
}
