using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardTrigger : MonoBehaviour
{
    [SerializeField] private GameObject puckGameObject;
    [SerializeField] private float punchForward;
    [SerializeField] private float punchUp;

    private void OnTriggerEnter(Collider other)
    {
        Invoke("PunchPuck", 0.3f);
    }
    private void PunchPuck()
    {
        if (puckGameObject)
        {
            puckGameObject.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * punchForward);
            puckGameObject.gameObject.GetComponent<Rigidbody>().AddForce(transform.up * punchUp);

        }
    }
}
