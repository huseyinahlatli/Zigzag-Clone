using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollisionControl : MonoBehaviour
{
    [SerializeField] private GroundDataTransmitter groundDataTransmitter;
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            groundDataTransmitter.SetGroundRigidbodyValue();
        }
    }
}
