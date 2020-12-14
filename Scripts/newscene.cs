using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newscene : MonoBehaviour
{
    public void loadnextlevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void gameover()
    {
        SceneManager.LoadScene(1);
    }
    public void drk()
    {
        SceneManager.LoadScene(2);
    }
}
