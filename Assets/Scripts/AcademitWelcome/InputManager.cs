using System;
using UnityEngine;

namespace AcademitWelcome
{
    public class InputManager : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Left Click");
            }
            if (Input.GetMouseButtonDown(1))
            {
                Debug.Log("Right Click");
            }
        }
    }
}