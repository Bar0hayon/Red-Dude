using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private GameObject m_Player;
    [SerializeField] private GameObject m_Coin;
    private Collider2D PlayerCollider;
    private Collider2D thisCollider;
    // Start is called before the first frame update
    void Start()
    {
        thisCollider = GetComponent<Collider2D>();
        PlayerCollider = m_Player.GetComponent<Collider2D>();
    }

    private void FixedUpdate()
    {
        if (thisCollider.IsTouching(PlayerCollider))
        {
            m_Player.GetComponent<CoinCollector>().AddCoin();
            m_Coin.SetActive(false);
        }
    }
}
