using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public static int Amount { get; private set; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            Amount++;
            player.DisplayGold();
        }

        Die();
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }
}