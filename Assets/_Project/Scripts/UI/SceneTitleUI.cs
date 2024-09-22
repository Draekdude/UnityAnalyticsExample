using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Project.Scripts.UI
{
    public class SceneTitleUI : MonoBehaviour
    {
        [SerializeField] private TMP_Text sceneTitleText;

        private void Awake()
        {
            sceneTitleText.text = SceneManager.GetActiveScene().name;
        }
    }
}
