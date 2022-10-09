using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] DataContainer dataContainer;
    [SerializeField] InputField username;
    // Start is called before the first frame update
    public void LoadNextScene()
    {
        dataContainer.username = username.text;
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
