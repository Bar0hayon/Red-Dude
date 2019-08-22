using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayerByTouch : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    private Collider2D PlayerCollider;
    private Collider2D thisCollider;

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
            Player.GetComponent<killablePlayer>().Kill();
        }
    }
}
