using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public int SceneNo;
    public bool changeToPrevS = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToScene()
    {
        if (changeToPrevS)
            SceneManager.LoadScene(globalVar.prevScene);
        else
            SceneManager.LoadScene(SceneNo);
    }
}
