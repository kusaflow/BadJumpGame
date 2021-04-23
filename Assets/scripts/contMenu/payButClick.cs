using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class payButClick : MonoBehaviour
{
    // Start is called before the first frame update
    public inputJump player;
    public Animator continueAnim;

    public GameObject preF;

    // Start is called before the first frame update




    public void payCLick()
    {
        if (globalVar.sd.cupcakes >= 100)
        {
            globalVar.sd.cupcakes -= 100;
            //
            resetPlayer();
        }

    }

    public void resetPlayer()
    {
        Instantiate(preF, new Vector3(player.transform.position.x, 0, 0), new Quaternion());

        player.transform.position = new Vector3(player.transform.position.x, 18, player.transform.position.z);
        player.rb.bodyType = RigidbodyType2D.Dynamic;
        player.VerticalForceForJump = 0;
        continueAnim.SetTrigger("cont");
    }
}
