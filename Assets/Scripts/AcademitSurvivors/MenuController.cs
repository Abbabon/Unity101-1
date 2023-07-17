using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AcademitSurvivors
{
    public class MenuController : MonoBehaviour
    {
        [SerializeField] private Button _startButton;

        private void Awake()
        {
            _startButton.onClick.AddListener(StartGame);
        }

        private void StartGame()
        {
            SceneManager.LoadSceneAsync("AcademitSurvivors");
        }

        private void OnDestroy()
        {
            _startButton.onClick.RemoveListener(StartGame);
        }
    }
}
