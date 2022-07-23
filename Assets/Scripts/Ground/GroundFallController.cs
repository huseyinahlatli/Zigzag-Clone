using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundFallController : MonoBehaviour
{
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
            
    }

    public IEnumerator SetRigidbodyValues()
    {
        yield return new WaitForSeconds(0.75f);
        _rigidbody.useGravity = true;
        _rigidbody.isKinematic = false;
    }
}
