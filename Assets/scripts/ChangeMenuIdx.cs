using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMenuIdx : MonoBehaviour
{

    public int ChangeMenuSceneTo = 0;


    public void ChangeMenuScene()
    {
        globalVar.MainMenuScreenIdx = ChangeMenuSceneTo;
    }
}
