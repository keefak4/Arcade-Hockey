using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Coins : MonoBehaviour
{
    [SerializeField] private Text textCoins;
    [SerializeField] private int coinsInt;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            coinsInt++;
            textCoins.text ="" + coinsInt;
            gameObject.SetActive(false);
            coinsInt = PlayerPrefs.GetInt("Score", 0);

        }
    }
}
