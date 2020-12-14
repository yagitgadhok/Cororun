using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class managerhandler : MonoBehaviour
{
    bool gameend = false;
    public GameObject completelvl;
    public float restartdelay = 0.5f;
    public void Endgame()
    {
        if(gameend == false)
        {
            gameend = true;
            Debug.Log("game over");
            Invoke("restart", restartdelay);
        }
    }
    public void darkscene()
    {
        SceneManager.LoadScene(3);
    }
    public void complete()
    {
        completelvl.SetActive(true);
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameover()
    {
        SceneManager.LoadScene(0);
    }
}
