using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killablePlayer : MonoBehaviour
{
    [SerializeField]
    private GameObject Player;

    [SerializeField]
    private GameObject UIgameOver;

    public void Kill()
    {
        killPlayer();
        gameOver();
    }

    private void gameOver()
    {
        UIgameOver.active = true;
    }

    private void killPlayer()
    {
        //Player.active = false;
        Player.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    
}
