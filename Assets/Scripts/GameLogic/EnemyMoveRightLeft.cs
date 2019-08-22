using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveRightLeft : MonoBehaviour
{
    [SerializeField] private GameObject m_RightBorder;
    [SerializeField] private GameObject m_LeftBorder;
    private Vector3 m_SingleStep = new Vector3(0.1f, 0f, 0f);
    private Vector3 m_SingleSpin = new Vector3(0f, 0f, 10f);
    private bool v_IsGoingRight = true;

    private void FixedUpdate()
    {
        float rightBorder = m_RightBorder.transform.position.x;
        float leftBorder = m_LeftBorder.transform.position.x;

        if( v_IsGoingRight && transform.position.x < rightBorder)
        {
            transform.position += m_SingleStep;
            transform.Rotate((m_SingleSpin * (-1)));
        }
        else
        {
            transform.position -= m_SingleStep;
            transform.Rotate(m_SingleSpin);
            if(v_IsGoingRight)
            {
                v_IsGoingRight = false;
            }

            if(transform.position.x <= leftBorder)
            {
                v_IsGoingRight = true;
            }
        }
    }
}
