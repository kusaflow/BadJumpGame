using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class progressLen : MonoBehaviour
{

    public RectTransform img;

    public float startX = 1000;

    public float Tarx = 1900;

    public GameObject player;
    public float playerposTar = 1900;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float pos = (Tarx - startX) * player.transform.position.x/1900;

        //Debug.Log(pos);
        //pos *= (Tarx - startX);
        //pos = pos + startX;
        pos += startX;
        img.anchoredPosition = new Vector2( pos, img.anchoredPosition.y);
    }
}
