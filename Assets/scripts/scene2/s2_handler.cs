using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class s2_handler : MonoBehaviour
{

    public bool isTouched;
    public bool isMouseDown;
    public float VerticalForceForJump = 0;

    public Rigidbody2D rb;
    public float fmulAdderPerFrame = 10;

    //gravity Scale
    public bool gravityIsPos = true;
    float gravityScale;
    float gravTimmer = 0;
    public float gravTimeToWaitInSec = 5;

    // Start is called before the first frame update
    void Start()
    {
        isTouched = false;
        isMouseDown = false;
        VerticalForceForJump = 0;

        globalVar.prevScene = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        InputJumpHandler();
        globalVar.score = (int)transform.position.x;

        gravityManager();
        

    }

    //gravity Manager 
    private void gravityManager()
    {
        if (gravityIsPos)
        {
            if (gravityScale < 1)
                gravityScale += 5 * Time.deltaTime;
            else
                gravityScale = 1;
        }
        else
        {

            if (gravityScale > -1)
                gravityScale -= 5 * Time.deltaTime;
            else
                gravityScale = -1;
        }

        rb.gravityScale = gravityScale;

        if (gravTimmer <= gravTimeToWaitInSec)
        {
            gravTimmer += 1 * Time.deltaTime;
        }
        else
        {
            gravTimmer = 0;
            gravityIsPos = !gravityIsPos;
        }

    }



    //JumpHandler

    private void InputJumpHandler()
    {
        if (Input.touchCount > 0)
        {
            Touch tou = Input.GetTouch(0);
            if (tou.phase == TouchPhase.Began)
            {
                isTouched = true;
            }
            else if (tou.phase == TouchPhase.Ended)
            {
                //isTouched = false;
                JumpThePlayer();
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            isMouseDown = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            //isMouseDown = false;
            JumpThePlayer();
        }

        //======================================================

        if (isTouched || isMouseDown)
        {
            VerticalForceForJump += fmulAdderPerFrame * Time.deltaTime;
            if (VerticalForceForJump >= 800)
                VerticalForceForJump = 800;
            //Debug.Log(VerticalForceForJump);
        }
        else
        {
            VerticalForceForJump = 0;
        }
    }

    public void JumpThePlayer()
    {
        int mul = 1;
        if (!gravityIsPos) mul = -1;

        if (rb != null && (isMouseDown || isTouched))
        {
            //Debug.Log("ffffffffffffffffffff");
            rb.AddForce(new Vector2(VerticalForceForJump / 2, VerticalForceForJump * mul)); ;
            isTouched = isMouseDown = false;
        }
    }
}
