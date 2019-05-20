using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int Index;

    public void SceneLoadSchueler()
    {
        SceneManager.LoadScene("Menu_schueler");
    }

    public void SceneLoadLehrer()
    {
        SceneManager.LoadScene("Menu_lehrer");
    }

    public void Quit()
    {
        Application.Quit();
    }
}