using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public PauseManager pauseManager;

    private void Awake()
    {
        pauseManager = GameObject.Find("Pause Manager").GetComponent<PauseManager>();
    }

    #region Load
    public void LoadScene(string sceneName)
    {
        SceneLoader.Instance.LoadScene(sceneName);
    }
    #endregion Load


    #region Pause
    public void PauseGame()
    {
        pauseManager.PauseGame();
    }

    public void ResumeGame()
    {
        pauseManager.ResumeGame();
    }
    #endregion Pause
}
