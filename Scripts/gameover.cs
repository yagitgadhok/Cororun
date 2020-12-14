using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    
    public void Quit()
    {
        //Debug.Log("game is over");
        Application.Quit();
    }
    public void restart()
    {
        SceneManager.LoadScene(1);
    }
}
