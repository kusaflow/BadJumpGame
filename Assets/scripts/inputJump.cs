using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class inputJump : MonoBehaviour
{

    public Animator tran1;
    public float animDuration = 1;


    public Animator continueAnim;

    public bool isTouched;
    public bool isMouseDown;
    public float VerticalForceForJump= 0;

    public Rigidbody2D rb;
    public float fmulAdderPerFrame = 20;

    //audio
    public AudioSource source;
    public AudioSource itsOver;

    public int NextLevelToLoad = 3;

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

        if (transform.position.y <= -10)
        {
            rb.bodyType = RigidbodyType2D.Static;
            transform.position = new Vector3(transform.position.x, -9, transform.position.z);
            continueAnim.SetTrigger("playerGaya");
        }
        
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
            rb.AddForce(new Vector2(VerticalForceForJump/2, VerticalForceForJump));
            isTouched = isMouseDown = false;
        }
    }

    public void loadLevel()
    {
        updateSaveData();
        saveloadOperations.saveToFile();
        StartCoroutine(loadTheLevel());
    }

    private void updateSaveData ()
    {
        if (!globalVar.sd.s1_hasB1 && transform.position.x >= 250)
        {
            globalVar.sd.s1_hasB1 = true;
        }
        if (!globalVar.sd.s1_hasB2 && transform.position.x >= 500)
        {
            globalVar.sd.s1_hasB2 = true;
        }
        if (!globalVar.sd.s1_hasB3 && transform.position.x >= 800)
        {
            globalVar.sd.s1_hasB3 = true;
        }
        if (!globalVar.sd.s1_hasB4 && transform.position.x >= 1100)
        {
            globalVar.sd.s1_hasB4 = true;
        }
        if (!globalVar.sd.s1_hasB5 && transform.position.x >= 1500)
        {
            globalVar.sd.s1_hasB5 = true;
        }
        if (!globalVar.sd.s1_hasB6 && transform.position.x >= 1900)
        {
            globalVar.sd.s1_hasB6 = true;
        }

        int prog = 0;
        if (transform.position.x >= 1900)
            prog = 100;
        else
            prog = (int)(transform.position.x* 100 / 1900);

        if (globalVar.sd.s1_progress < prog)
            globalVar.sd.s1_progress = prog;

        Debug.Log(prog);

    }

    IEnumerator loadTheLevel()
    {
       

        tran1.SetTrigger("start");

        yield return new WaitForSeconds(animDuration);

        SceneManager.LoadScene(NextLevelToLoad);

    }

    
    void OnCollisionEnter2D(Collision2D col)
    {
        if (source)
        {
            //source.Play();
        }
    }

}
