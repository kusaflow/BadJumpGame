using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeSpriteIcon : MonoBehaviour
{

    public Sprite[] img = new Sprite[30];

    public Image progImg;

    int idx;

    public SpriteRenderer rend;

    // Start is called before the first frame update
    void Start()
    {

        idx = Random.Range(0, 29);

        if (idx <= 29) {
            rend.sprite = img[idx];
            progImg.sprite = img[idx];
        }

    }

}
