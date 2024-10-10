using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OptionMenu()
    {
        Debug.Log("Masuk Ke Option");
    }

    public void CreditMenu()
    {
        Debug.Log("Masuk Ke Credit");
    }

    public void ExitGame()
    {
        Debug.Log("Keluar Game");
    }
}
