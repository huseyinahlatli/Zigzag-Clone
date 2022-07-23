using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPositionController : MonoBehaviour
{
    [SerializeField] private float endYValue;
    private GroundSpawnController groundSpawnController;
    private Rigidbody _rigidbody;
    private int _groundDirection;
    void Start()
    {
        groundSpawnController = FindObjectOfType<GroundSpawnController>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        CheckGroundVerticalPosition();
    }

    private void CheckGroundVerticalPosition()
    {
        if (transform.position.y <= endYValue)
        {
            SetRigidbodyValues();
            SetGroundNewPosition();
        }
    }

    private void SetGroundNewPosition()
    {
        var position = groundSpawnController.lastGroundObject.transform.position;
        _groundDirection = Random.Range(0, 2);
        if (_groundDirection == 0)
        {
            transform.position = new Vector3(
                position.x -1f,
                position.y,
                position.z
            );
        }
        else
        {
            transform.position = new Vector3(
                position.x,
                position.y,
                position.z + 1f
            );
        }
        groundSpawnController.lastGroundObject = gameObject;
    }

    private void SetRigidbodyValues()
    {
        _rigidbody.isKinematic = true;
        _rigidbody.useGravity = false;
    }
}
