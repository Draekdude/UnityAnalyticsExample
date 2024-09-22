using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace _Project.Scripts.UI
{
    public class SceneSelectionUI : MonoBehaviour
    {
        [SerializeField] private Button previousScene;
        [SerializeField] private Button nextScene;

        private void Awake()
        {
            var activeSceneIndex = SceneManager.GetActiveScene().buildIndex;
            previousScene.onClick.AddListener(()=> LoadScene(activeSceneIndex - 1));
            nextScene.onClick.AddListener(()=> LoadScene(activeSceneIndex + 1));
            UpdateButtonStates(activeSceneIndex);
        }

        private void LoadScene(int sceneIndex)
        {
            // Validate if the index is within the build settings range
            if (sceneIndex >= 0 && sceneIndex < SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(sceneIndex);
            }
        }

        private void UpdateButtonStates(int activeSceneIndex)
        {
            // Disable the previous button if on the first scene
            previousScene.interactable = activeSceneIndex > 0;

            // Disable the next button if on the last scene
            nextScene.interactable = activeSceneIndex < SceneManager.sceneCountInBuildSettings - 1;
        }
    }
}
