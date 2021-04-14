using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakablePlat : MonoBehaviour
{
    public Animator anim;
    public SpriteRenderer sr;

    bool gotHit = false;
    float timer = 0;
    bool isInRight = false;
    float xpos;


    // Start is called before the first frame update
    void Start()
    {
        xpos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        sr.color = new Color((timer / 160), 0,0,1);
        if (gotHit)
        {
            if (timer >= 150)
            {                
                 anim.SetTrigger("gotHit");
            }
            else
            {
                timer += 100 * Time.deltaTime;
                if (isInRight)
                {
                    transform.position = new Vector3(xpos- .07f, transform.position.y, transform.position.z);
                }
                else
                {
                    transform.position = new Vector3(xpos + .07f, transform.position.y, transform.position.z);
                }

                isInRight = !isInRight;
            }
        }   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            gotHit = true;
        }
    }
}
