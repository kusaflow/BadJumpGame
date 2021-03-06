using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ss2_handler : MonoBehaviour
{

    public bool isTouched;
    public bool isMouseDown;
    public float VerticalForceForJump = 0;

    public Rigidbody2D rb;
    public float fmulAdderPerFrame = 20;


    // Start is called before the first frame update
    void Start()
    {
        isTouched = false;
        isMouseDown = false;
        VerticalForceForJump = 0;
    }

    // Update is called once per frame
    void Update()
    {
        InputJumpHandler();

    }


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

        if (rb != null && (isMouseDown || isTouched))
        {
            //Debug.Log("ffffffffffffffffffff");
            rb.AddForce(new Vector2(VerticalForceForJump / 2, VerticalForceForJump)); ;
            isTouched = isMouseDown = false;
        }

    }
}
