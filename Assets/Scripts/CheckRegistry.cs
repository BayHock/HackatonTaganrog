using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CheckRegistry : MonoBehaviour
{
    [SerializeField] private TMP_InputField login;
    [SerializeField] private TMP_InputField password;
    public bool isRegistry = false;

    public void CheckValidation()
    {
        string _login = login.text;
        string _password = password.text;

        if (_login == "" || _password == "")
        {
            isRegistry = false;
            Debug.Log("Login or password not correctly");            
        }
        else
        {
            isRegistry = true;
            Debug.Log(isRegistry);
            Debug.Log("Registry success");
            LoadScene();
        }
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

