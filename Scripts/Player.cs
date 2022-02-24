using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] private UnityEvent _playerEncounter;
    [SerializeField] private TMP_Text _textGold;
    [SerializeField] private GameObject _gameOver;
    [SerializeField] private int _totalAmount = 30;
    [SerializeField] private GameObject _menu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            _menu.SetActive(true);
        }
    }

    public void DisplayGold()
    {
        if (Coin.Amount == _totalAmount)
        {
            _gameOver.SetActive(true);
            Time.timeScale = 0f;
        }

        _textGold.text = "Количество монет = " + Coin.Amount;
    }

    public void EncounterEnemy()
    {
        _playerEncounter?.Invoke();
    }
}
