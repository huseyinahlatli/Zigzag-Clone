using System;
using UnityEngine;

namespace Game_Manager
{
    public class LevelController : MonoBehaviour
    {
        private void Start()
        {
            Time.timeScale = 0f;
        }

        public void PlayGame()
        {
            UIController.Instance.PlayGameUI();
        }
    }
}
