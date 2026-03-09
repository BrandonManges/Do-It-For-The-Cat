using UnityEngine;
using UnityEngine.SceneManagement;

public class NewLevelTrigger : MonoBehaviour
{
    public string LvlToLoad;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            Debug.Log("I have found a player");
            SceneManager.LoadScene(LvlToLoad);
        }
    }
}
