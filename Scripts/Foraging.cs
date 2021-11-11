using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foraging : MonoBehaviour
{
    [SerializeField] private GameObject _coin;

    public static int amountCoins = 0;
    public static bool Collision = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Batman>(out Batman batman))
        {
            _coin.SetActive(false);
            amountCoins++;
            Collision = true;
        }
    }
}
