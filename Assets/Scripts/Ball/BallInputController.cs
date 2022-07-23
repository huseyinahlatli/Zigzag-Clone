using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInputController : MonoBehaviour
{
    [SerializeField] public Vector3 ballDirection;
    private AudioSource _audioSource;
    
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        ballDirection = Vector3.left;
    }

    void Update()
    {
        HandleBallInput();
    }

    private void HandleBallInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CheckBallDirection();
            _audioSource.Play();
        }
    }

    private void CheckBallDirection()
    {
        if (ballDirection.x == -1)
            ballDirection = Vector3.forward;
        else
            ballDirection = Vector3.left;
    }
}
