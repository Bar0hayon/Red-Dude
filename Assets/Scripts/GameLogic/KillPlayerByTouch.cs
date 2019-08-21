using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayerByTouch : MonoBehaviour
{
    public GameObject Player;

    private Collider2D PlayerCollider;

    private Collider2D thisCollider;


    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Debug.Log("2d enter");
    //}

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("3d enter");
    //}

    // Start is called before the first frame update
    void Start()
    {
        thisCollider = GetComponent<Collider2D>();
        PlayerCollider = Player.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(thisCollider.IsTouching(PlayerCollider))
        {
            Debug.Log("touching!");
            Player.GetComponent<killablePlayer>().Kill();
        }
    }
}
