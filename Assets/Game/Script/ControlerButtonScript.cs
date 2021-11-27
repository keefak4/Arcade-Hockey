using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class ControlerButtonScript : MonoBehaviour
{
    [SerializeField]private Button[] buttons;
    private int levelsClouse;
    private void Start()
    {
        levelsClouse = PlayerPrefs.GetInt("Levels", 1);
        for(int i = 0;i < buttons.Length;i++)
        {
            buttons[i].interactable = false;
        }
        for(int i = 0;i < levelsClouse ;i++)
        {
            buttons[i].interactable = true;
        }
    }
    public void SceneLevel(int level)
    {
        SceneManager.LoadScene(level);
    }
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
    }
}
