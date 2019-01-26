using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour{
    public void StartBtn(){
        Debug.Log("StartBtn");
        SceneManager.LoadScene("Main");
    }

    public void QuitBtn(){
        Application.Quit();
    }
}