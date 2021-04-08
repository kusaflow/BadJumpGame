using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class logoTomenu : MonoBehaviour
{

    float timer = 0;
    public int sceneToGo = 1;
    public float TimeToWait = 200;

    

    // Start is called before the first frame update
    void Start()
    { 
        timer = 0;   
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= TimeToWait)
        {
            SceneManager.LoadScene(sceneToGo);
        }
        else
        {
            timer += 100 * Time.deltaTime;
        }   
    }

    
}
