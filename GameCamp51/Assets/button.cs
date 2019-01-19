using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class button : MonoBehaviour
{
    public void StartBtn()
    {
        Debug.Log("StartBtn");
        SceneManager.LoadScene("Game");
    }

    public void QuitBtn()
    {
        Application.Quit();
    }
   

}
