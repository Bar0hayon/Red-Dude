using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    private int m_NumOfCoinsCollected = 0;
    [SerializeField] private Text m_TextNumOfCoins;

    public int GetNumOfCoinsCollected()
    {
        return m_NumOfCoinsCollected;
    }

    public void AddCoin()
    {
        m_NumOfCoinsCollected++;
        m_TextNumOfCoins.text = m_NumOfCoinsCollected.ToString();
    }
}
