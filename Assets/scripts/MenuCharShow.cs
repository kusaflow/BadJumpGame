using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuCharShow : MonoBehaviour
{

    public Sprite[] imgs;
    public Image imgOnMenu;

    MenuCharShow()
    {
        imgs = new Sprite[30];

    }

    // Start is called before the first frame update
    void Start()
    {
        imgOnMenu.sprite = imgs[globalVar.charIdx];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
