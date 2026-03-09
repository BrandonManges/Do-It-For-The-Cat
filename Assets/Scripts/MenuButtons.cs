using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public string LvlToLoad;
    public void PlayGame()
    {
        SceneManager.LoadScene(LvlToLoad);
    }

    public void QuitGame()
    {
        Debug.Log("Quit Button pressed");
        Application.Quit();
    }
}
