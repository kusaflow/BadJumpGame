using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cupcakesWon : MonoBehaviour
{

    public Text score;
    int val;

    // Start is called before the first frame update
    void Start()
    {
        val = 0;    
    }

    // Update is called once per frame
    void Update()
    {
        if (val < globalVar.score/2)
        {
            val += 3;
            score.text = val.ToString();
        }
    }
}
