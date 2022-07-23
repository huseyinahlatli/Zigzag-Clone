using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawnController : MonoBehaviour
{
    public GameObject lastGroundObject;
    [SerializeField] private GameObject groundPrefab;
    private GameObject newGroundObject;
    private int groundDirection;
        
    void Start()
    {
        GenerateRandomNewGrounds();
    }

    public void GenerateRandomNewGrounds()
    {
        for (int i = 0; i < 75; i++)
        {
            CreateNewGround();
        }
    }
    
    private void CreateNewGround()
    {
        groundDirection = Random.Range(0, 2);
        var position = lastGroundObject.transform.position;
        
        if (groundDirection == 0)
        {
            newGroundObject = Instantiate(
               groundPrefab,
               new Vector3(position.x - 1f, position.y, position.z),
               Quaternion.identity
            );
            lastGroundObject = newGroundObject;
        }
        
        else
        {
            newGroundObject = Instantiate(
                groundPrefab,
                new Vector3(position.x, position.y, position.z + 1f),
                Quaternion.identity
            );
            lastGroundObject = newGroundObject;
        }
    }
}
