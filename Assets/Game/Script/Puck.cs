using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Puck : MonoBehaviour
{
    private void Update()
    {
        if(transform.position.y < -1f)
        {
            Destroy(gameObject);
        }
    }
}
