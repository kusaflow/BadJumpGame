using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class payButClick : MonoBehaviour
{
    // Start is called before the first frame update
    public inputJump player;
    public Animator continueAnim;

    // Start is called before the first frame update

    


    public void payCLick()
    {
        //
        player.transform.position = new Vector3(player.transform.position.x, 5, player.transform.position.z);
        player.rb.bodyType = RigidbodyType2D.Dynamic;

        continueAnim.SetTrigger("cont");

    }
}
