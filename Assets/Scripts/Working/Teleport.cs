using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Transform initialPosition;
    [SerializeField] Transform finalPosition;
    [SerializeField] Vector3 finalPositionVector;

    private void Start()
    {
        finalPositionVector = finalPosition.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player = other.gameObject.transform;
            player.transform.position = finalPositionVector;      
        }
    }
}
