using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveUpDown : MonoBehaviour
{
    [SerializeField] private float m_MaxHeightToAdd = 10;
    [SerializeField] private bool v_IsSpinning = false;
    private Vector3 m_StartingPosition;
    private Vector3 m_SingleStep = new Vector3(0f, 0.1f, 0f);
    private Vector3 m_SingleSpin = new Vector3(0f, 0f, 10f);
    private bool v_IsGoingUp = true;
    
    // Start is called before the first frame update
    void Start()
    {
        m_StartingPosition = transform.position;
    }

    private void FixedUpdate()
    {
        float yTop = m_StartingPosition.y + m_MaxHeightToAdd;
        if (v_IsGoingUp && (transform.position.y < yTop))
        {
            transform.position += m_SingleStep;
        }
        else
        {
            transform.position -= m_SingleStep;
            if (v_IsGoingUp)
            {
                v_IsGoingUp = false;
            }

            if (transform.position.y <= m_StartingPosition.y)
            {
                v_IsGoingUp = true;
            }
        }

        if (v_IsSpinning)
        {
            transform.Rotate(m_SingleSpin);
        }
    }
}
