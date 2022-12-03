using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public void LoadScene()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);     
    }
}
