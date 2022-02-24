using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	[SerializeField] private GameObject _coin;
	[SerializeField] private float _wait;

	private void Start()
	{
		_coin.SetActive(true);
		StartCoroutine(SpawnCoin());
	}

	private IEnumerator SpawnCoin()
	{
		var waitForSeconds = new WaitForSeconds(_wait);

		while (true)
		{
			Instantiate(_coin, transform.position, transform.rotation);

			yield return waitForSeconds;
		}
	}
}