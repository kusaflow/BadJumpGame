using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcGen_01 : MonoBehaviour
{
    /*
    //6 stages-----------------------------------------------------
    1.
    normal same level Plats

    2.
    z upDowm 
    
    3.
    breakable plats 
    jumpers
    
    4. 
    movable upDown 
    
    5.
    push BackWard

    6.
    round top
    triangle top


    

    //Powers

    //=============================================================
    */

    /*
    //1==============================
    for (int i = 0; i < 30; i++)
    {
        GameObject instance = (GameObject)Instantiate(preF, new Vector3(CurrDrawPos, -5, 0), new Quaternion());
        plat.Enqueue(instance);
        CurrDrawPos += Random.Range(5, 15);
    }
    ---------------------------------------

    2===================================================
    for (int i = 0; i < 30; i++)
    {
        GameObject instance = (GameObject)Instantiate(preF, new Vector3(CurrDrawPos, Random.Range(-10, 0), 0), new Quaternion());
        plat.Enqueue(instance);
        CurrDrawPos += Random.Range(8, 15);
    }
    //--------------------------------------------------

    //3======================================================
    //jumper
     for (int i = 0; i < 30; i++)
    {
        GameObject instance = (GameObject)Instantiate(Jumper, new Vector3(CurrDrawPos, Random.Range(-10, -5), 0), new Quaternion());
        plat.Enqueue(instance);
        CurrDrawPos += Random.Range(5, 15);
    }


    //breakable
    for (int i = 0; i < 30; i++)
    {
        GameObject instance = (GameObject)Instantiate(breakable, new Vector3(CurrDrawPos, Random.Range(-10, -5), 0), new Quaternion());
        plat.Enqueue(instance);
        CurrDrawPos += Random.Range(5, 15);
    }
    //------------------------------------------------------

    //4=====================================================================
     for (int i = 0; i < 30; i++)
    {
        GameObject instance = (GameObject)Instantiate(upDownPlat, new Vector3(CurrDrawPos, -5, 0), new Quaternion());
        plat.Enqueue(instance);
        CurrDrawPos += Random.Range(5, 15);
    }
    //----------------------------------------------------------------------\

    //5 ========================================================================
    for (int i = 0; i < 30; i++)
    {
        GameObject instance = (GameObject)Instantiate(preF, new Vector3(CurrDrawPos, Random.Range(-10, 0), 0), new Quaternion());
        plat.Enqueue(instance);
        CurrDrawPos += Random.Range(5, 15);
    }

    //-------------------------------------------------------------------------
    */


    float nextMil = 100;
    float CurrDrawPos = 0;
    public GameObject preF;
    public GameObject Jumper;
    public GameObject breakable;
    public GameObject upDownPlat;
    public GameObject backPush;


    Queue<GameObject> plat = new Queue<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        CurrDrawPos = 15;
        nextMil = 200;


        int GenBracket = 5; 

        for (int i=0; i < 30; i++)
        {
            int ToDraw = Random.Range(1, GenBracket + 1);
            SpawnBlock(ToDraw);
        }
         
    
    } 

    // Update is called once per frame
    void Update()
    {
        if (nextMil <= transform.position.x)
        {
            int typeToGen = 1;

            //set typrToGen


            typeToGen = Random.Range(1, typeToGen+1);
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


    void SpawnBlock(int idx)
    {

        if (idx == 1)
        {
            //1==============================
            
            GameObject instance = (GameObject)Instantiate(preF, new Vector3(CurrDrawPos, -5, 0), new Quaternion());
            plat.Enqueue(instance);
            CurrDrawPos += Random.Range(5, 15);
            
            //---------------------------------------
        }
        else if (idx == 2)
        {
            //2===================================================
            GameObject instance = (GameObject)Instantiate(preF, new Vector3(CurrDrawPos, Random.Range(-10, 0), 0), new Quaternion());
            plat.Enqueue(instance);
            CurrDrawPos += Random.Range(8, 15);
            
            //--------------------------------------------------
        }
        else if (idx == 3)
        {
            if ((int)(Random.Range(1, 21)) % 2 == 0)
            {
                //3======================================================
                //jumper
                
                GameObject instance = (GameObject)Instantiate(Jumper, new Vector3(CurrDrawPos, Random.Range(-10, -5), 0), new Quaternion());
                plat.Enqueue(instance);
                CurrDrawPos += Random.Range(5, 15);
                
            }
            else
            {
                //breakable
                GameObject instance = (GameObject)Instantiate(breakable, new Vector3(CurrDrawPos, Random.Range(-10, -5), 0), new Quaternion());
                plat.Enqueue(instance);
                CurrDrawPos += Random.Range(5, 15);
                
            }
            //------------------------------------------------------
        }
        else if (idx == 4)
        {
            //4=====================================================================
            GameObject instance = (GameObject)Instantiate(upDownPlat, new Vector3(CurrDrawPos, -5, 0), new Quaternion());
            plat.Enqueue(instance);
            CurrDrawPos += Random.Range(5, 15);
            //----------------------------------------------------------------------\
        }
        else if (idx == 5)
        {
            //5 ========================================================================
            GameObject instance = (GameObject)Instantiate(backPush, new Vector3(CurrDrawPos, Random.Range(-10, 0), 0), new Quaternion());
            plat.Enqueue(instance);
            CurrDrawPos += Random.Range(8, 15);
            

            //-------------------------------------------------------------------------
        }
    }


}
