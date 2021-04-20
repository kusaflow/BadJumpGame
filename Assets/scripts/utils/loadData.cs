
using UnityEngine;

public class loadData : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        globalVar.sd = new saveData();
        globalVar.sd = saveloadOperations.LoadToGame();

        Debug.Log(Application.persistentDataPath);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
