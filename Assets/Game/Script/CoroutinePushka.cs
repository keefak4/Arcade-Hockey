using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutinePushka : MonoBehaviour
{
    [SerializeField] private GameObject puckGameObject;
    [SerializeField] private float punch;
    private void OnTriggerEnter(Collider other)
    {
        Invoke("PunchPuck", .5f);
    }
    private void PunchPuck()
    {
        if (puckGameObject)
        {
            puckGameObject.gameObject.GetComponent<Rigidbody>().AddForce(transform.right * punch);
        }
    }
}
