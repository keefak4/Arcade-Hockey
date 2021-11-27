using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpPlaneForce : MonoBehaviour
{
    [SerializeField] private GameObject puckGameObject;
    [SerializeField] private float punch;
    private void OnTriggerEnter(Collider other)
    {
        Invoke("PunchPuck",0.01f);
    }
    private void PunchPuck()
    {
        if (puckGameObject)
        {
            puckGameObject.gameObject.GetComponent<Rigidbody>().AddForce(transform.up * punch);
        }
    }
}
