using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killablePlayer : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject m_UIgameOver;

    public void Kill()
    {
        killPlayer();
        gameOver();
    }

    private void gameOver()
    {
        m_UIgameOver.SetActive(true);
    }

    private void killPlayer()
    {
        Player.GetComponent<SpriteRenderer>().enabled = false;
    }
}
