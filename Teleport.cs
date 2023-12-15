using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportPoint;


    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = teleportPoint.transform.position;


    }
}
