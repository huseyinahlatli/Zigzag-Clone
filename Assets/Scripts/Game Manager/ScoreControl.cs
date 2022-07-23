using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class ScoreControl : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    private int score = 0;

    private void Update()
    {
        if (transform.position.y <= -5f)
            SceneManager.LoadScene(sceneBuildIndex: 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            score += 1;
            scoreText.text = "Score: " + score;
        }
    }
}
