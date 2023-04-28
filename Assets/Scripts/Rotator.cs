using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float m_myAngle = 0.015f;
    public float m_RotateAmount = 30f;

    public float m_SimulationTime = 30f;
    
    void Update()
    {
        /*
        if(m_SimulationTime > 0f)
        {
            gameObject.GetComponent<Transform>().RotateAround(new Vector3(0f, 1f, 0f), m_myAngle);
            m_SimulationTime = m_SimulationTime - Time.deltaTime;
        }
        */
        if (m_RotateAmount > 0f)
        {
            gameObject.GetComponent<Transform>().RotateAround(new Vector3(0f, 1f, 0f), m_myAngle);
            m_RotateAmount -= m_myAngle;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
