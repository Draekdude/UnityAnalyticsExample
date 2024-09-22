using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Scripts.UI
{
    public class ActionUI : MonoBehaviour
    {
        [SerializeField] private TMP_Text countText;
        [SerializeField] private Button actionButton;
        [SerializeField] private TMP_Text actionButtonText;

        private string _clickAction;
        private int _count;

        private void Awake()
        {
            actionButton.onClick.AddListener(HandleActionOnClick);
        }

        private void HandleActionOnClick()
        {
            _count++;
            //here we display how many times we've clicked
            countText.text = _count.ToString();
            //this would do something in the game
            DoSomething();
            //here we need to attach to analytics
        }


        public void SetUp(string clickAction)
        {
            //initializes text count
            countText.text = _count.ToString();
            //adds action string to button label
            actionButtonText.text = clickAction;
            //assigns action to this monobehavior for the analytics to know what this action does
            _clickAction = clickAction;
        }

        private void DoSomething()
        {
            print($"Here we just performed the {_clickAction} action.");
        }
    }
}
