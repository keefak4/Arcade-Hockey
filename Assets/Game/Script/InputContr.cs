using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputContr : MonoBehaviour
{
    [SerializeField] private float speedContrVert;
    [SerializeField] private float speedContrHor;

    private Vector3 vectorContr;
     

    private void Update()
    {
        if (Input.GetButton("Vertical")) Control();
        if (Input.GetButton("Horizontal")) RotateContr();
    }
    private void Control()
    {
        vectorContr = transform.forward * Input.GetAxis("Vertical");
        transform.position = Vector3.MoveTowards(transform.position,transform.position + vectorContr, speedContrVert * Time.deltaTime);
    }
    private void RotateContr()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * speedContrHor, 0);
    }
}
