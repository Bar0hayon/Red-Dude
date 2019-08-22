using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverNotifier : MonoBehaviour
{
    [SerializeField] private GameObject m_PlayerUI;
    // Start is called before the first frame update
    void Start()
    {
        m_PlayerUI.GetComponent<PlayerMenus>().GameOver();
    }
}
