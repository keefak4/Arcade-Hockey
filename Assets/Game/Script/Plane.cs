using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    [SerializeField] private GameObject planeGameObject;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            planeGameObject.SetActive(false);
        }
    }
}
