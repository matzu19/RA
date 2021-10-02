using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    [SerializeField]  int number;
 

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + number);
    }
    public void QuitGame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
