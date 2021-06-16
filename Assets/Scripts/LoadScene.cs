using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadLevel(string scene)
    {
        switch (scene)
        {
            case "Exit":
                Application.Quit();
                break;
            case "ExitGame":
                RecordsScript.setRecords(GameManager.records);
                SceneManager.LoadScene("MainMenu");
                break;
            default:
                SceneManager.LoadScene(scene);
                break;
        }
    }
}
