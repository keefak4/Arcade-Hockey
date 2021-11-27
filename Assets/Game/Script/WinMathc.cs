using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class WinMathc : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            UnlockLevel();
            SceneManager.LoadScene(0);
        }
    }
    private void UnlockLevel()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        if(currentLevel >= PlayerPrefs.GetInt("Levels"))
        {
            PlayerPrefs.SetInt("Levels", currentLevel + 1);
        }
    }
}
