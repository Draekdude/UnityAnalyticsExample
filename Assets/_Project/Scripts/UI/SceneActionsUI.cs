using System.Collections.Generic;
using UnityEngine;

namespace _Project.Scripts.UI
{
    public class SceneActionsUI : MonoBehaviour
    {
        [SerializeField] private List<string> actions;
        [SerializeField] private ActionUI actionUIPrefab;

        private void Awake()
        {
            foreach (var action in actions)
            {
                var actionUI = Instantiate(actionUIPrefab, transform);
                actionUI.SetUp(action);
            }
        }
    }
}
