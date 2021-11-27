using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyDosk : MonoBehaviour
{
    [SerializeField]private Transform start;
    [SerializeField]private Transform end;
    [SerializeField] private Transform end2;


    private float arriveTime = 10f;

   
    void Update()
    {
        transform.position = Vector3.Lerp(start.position, end.position, Mathf.PingPong(Time.time / arriveTime, 1f));
    }
}
