using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasAphaHandler : MonoBehaviour
{
    public int SceneIdxShouldBe;
    public CanvasGroup canvGroup;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        if (canvGroup)
            if (globalVar.MainMenuScreenIdx != SceneIdxShouldBe)
                canvGroup.alpha = 0;
            else
                canvGroup.alpha = 1;
        
    }
}
