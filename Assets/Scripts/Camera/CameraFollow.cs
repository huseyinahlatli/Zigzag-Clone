using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform ballTransform;
    [SerializeField][Range(0, 3)] private float lerpValue;
    private Vector3 offset;
    private Vector3 newPosition;
    
    void Start()
    {
        offset = transform.position - ballTransform.position;
    }

    void LateUpdate()
    {
        CameraSmoothFollow();
    }

    private void CameraSmoothFollow()
    {
        newPosition = Vector3.Lerp(transform.position, ballTransform.position + offset, lerpValue * Time.deltaTime);
        transform.position = newPosition;
    }
}
