using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class procGen : MonoBehaviour
{

    float nextMil = 100;
    float CurrDrawPos = 0;
    public GameObject preF;

    

    Queue<GameObject> plat = new Queue<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        CurrDrawPos = 5;
        nextMil = 200;
        for (int i = 0; i < 30; i++)
        {
            GameObject instance = (GameObject)Instantiate(preF, new Vector3(CurrDrawPos, -15, 0), new Quaternion());
            plat.Enqueue(instance);
            CurrDrawPos += Random.Range(5, 15);
        }
        globalVar.prevScene = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {

        globalVar.score = (int)transform.position.x;
        
        if (nextMil <= transform.position.x)
        {
            nextMil = CurrDrawPos;
            for (int i = 0; i < 10; i++)
            {
                GameObject instance = (GameObject)Instantiate(preF, new Vector3(CurrDrawPos, -15, 0), new Quaternion());
                plat.Enqueue(instance);
                Destroy(plat.Dequeue());
                CurrDrawPos += Random.Range(5, 15);
            }
        }


    }
}
