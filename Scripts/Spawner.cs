using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	[SerializeField] private GameObject _coin;
	[SerializeField] private float _waitTime = 2f;
	[SerializeField] private float _time = 0f;
	[SerializeField] private float _end = 4f;

	private void Start()
	{
		while (_time <= _end)
		{
			StartCoroutine(SpawnCoin());
		}
	}

	private IEnumerator SpawnCoin()
	{
		var waitForOneSeconds = new WaitForSeconds(1f);

		_time++;

		Instantiate(_coin, transform.position, transform.rotation);

		if (_time >= _end)
		{
			yield break;
		}

		if (_waitTime > .2f)
		{
			Invoke(nameof(SpawnCoin), _waitTime);
		}

		yield return waitForOneSeconds;
	}
}