using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMenus : MonoBehaviour
{
    public static bool v_GameIsPaused = false;
    private static bool v_GameOver = false;
    [SerializeField] private GameObject m_PauseMenuUI;
    [SerializeField] private GameObject m_PauseButton;
    [SerializeField] private GameObject m_FinishLineFlag;
    [SerializeField] private GameObject m_Player;
    [SerializeField] private GameObject m_WonMenu;

    // Update is called once per frame
    void Update()
    {
        if(m_Player.transform.position.x >= m_FinishLineFlag.transform.position.x)
        {
            //GameOver();
            m_WonMenu.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {
            if (!v_GameOver)
            {
                if (v_GameIsPaused)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
            }
        }
    }

    public void GameOver()
    {
        v_GameOver = true;
        Time.timeScale = 0f;
        m_PauseButton.SetActive(false);
    }

    public void Resume()
    {
        m_PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        v_GameIsPaused = false;
        m_PauseButton.SetActive(true);
        v_GameOver = false;
    }

    public void Pause()
    {
        m_PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        v_GameIsPaused = true;
        m_PauseButton.SetActive(false);
    }

    public void QuitToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGameScene()
    {
        SceneManager.LoadScene(1);
    }
}
