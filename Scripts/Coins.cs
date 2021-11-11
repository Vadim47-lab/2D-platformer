using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Coins : MonoBehaviour
{
    [SerializeField] private UnityEvent _reached;
    [SerializeField] private Text _coinText;
    [SerializeField] private GameObject _gameOver;
    [SerializeField] private int _gameEnd = 45;


    private void Update()
    {
        _coinText.text = "Количество монет = " + Foraging.amountCoins;

        if (Foraging.Collision == true)
        {
            _reached?.Invoke();
            Foraging.Collision = false;
        }

        if (Foraging.amountCoins == _gameEnd)
        {
            _gameOver.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}