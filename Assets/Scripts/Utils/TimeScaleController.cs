using System.Collections.Generic;
using UnityEngine;

namespace Utils
{
        public class TimeScaleController : MonoBehaviour
        {
                [SerializeField] private bool _enabled;
                [SerializeField] private List<float> _timescaleScales = new List<float> {0.1f, 0.25f, 0.5f, 0.75f, 1f, 1.5f, 2f, 3f, 4f};

                private float _defaultTimescale;
                private int _currentIndex = 0;
                private bool _paused;

                private void Awake()
                {
                        _defaultTimescale = Time.timeScale;
                        ResetTimescaleIndex();
                }

                private void ResetTimescaleIndex()
                {
                        _currentIndex = _timescaleScales.IndexOf(_defaultTimescale);
                        if (_currentIndex < 0)
                        {
                                _currentIndex = 0;
                        }
                }

                private void Update()
                {
                        if (_enabled)
                        {
                                if (Input.GetKeyDown(KeyCode.LeftArrow))
                                {
                                        if (!_paused)
                                        {
                                                _currentIndex = Mathf.Max(_currentIndex - 1, 0);
                                                Time.timeScale = _timescaleScales[_currentIndex];        
                                        }
                                }
                                else if (Input.GetKeyDown(KeyCode.RightArrow))
                                {
                                        if (!_paused)
                                        {
                                                _currentIndex = Mathf.Min(_currentIndex + 1, _timescaleScales.Count - 1);
                                                Time.timeScale = _timescaleScales[_currentIndex];       
                                        }
                                }
                                if (Input.GetKeyDown(KeyCode.Z))
                                {
                                        if (_paused)
                                        {
                                                _paused = false;
                                                Time.timeScale = _defaultTimescale;  
                                                ResetTimescaleIndex();
                                        }
                                        else
                                        {
                                                _paused = true;
                                                Time.timeScale = 0;
                                        }
                                }
                        }

                }
        }
}