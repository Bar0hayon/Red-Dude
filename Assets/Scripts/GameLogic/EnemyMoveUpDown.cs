using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveUpDown : MonoBehaviour
{
    [SerializeField] private float m_MaxHeightToAdd = 10;
    private Vector3 m_StartingPosition;
    private Vector3 m_SingleStep = new Vector3(0f, 0.1f, 0f);
    private bool v_IsGoingUp = true;
    
    // Start is called before the first frame update
    void Start()
    {
        m_StartingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float yTop = m_StartingPosition.y + m_MaxHeightToAdd;
        if (v_IsGoingUp && (transform.position.y < yTop))
        {
            transform.position += m_SingleStep;
        }
        else
        {
            transform.position -= m_SingleStep;
            if(v_IsGoingUp)
            {
                v_IsGoingUp = false;
            }

            if(transform.position.y <= m_StartingPosition.y)
            {
                v_IsGoingUp = true;
            }
        }
    }
}
