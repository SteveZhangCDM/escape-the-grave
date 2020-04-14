using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class popmenu : MonoBehaviour
{
    public void LoadThisLevel()
    {
        SceneManager.LoadScene("level1");
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene("level2");
    }
}
