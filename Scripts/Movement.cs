using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]
public class Movement : MonoBehaviour
{
    [SerializeField] private UnityEvent _reached;
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _jumpForce;
    [SerializeField] private string _Run2 = "_Run2";
    [SerializeField] private string _Run1 = "_Run1";
    [SerializeField] private string _Stop = "_Stop";
    [SerializeField] private string _Jump = "_Jump";

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            _animator.SetBool(_Run2, false);
            _animator.SetBool(_Stop, false);
            _animator.SetBool(_Jump, false);
            _animator.SetBool(_Run1, true);
            transform.Translate(_speed * Time.deltaTime, 0, 0, 0);
            _speed = 3;
        }

        if (Input.GetKey(KeyCode.A))
        {
            _animator.SetBool(_Run1, false);
            _animator.SetBool(_Stop, false);
            _animator.SetBool(_Jump, false);
            _animator.SetBool(_Run2, true);
            transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
            _speed = 3;
        }

        if (Input.GetKey(KeyCode.S))
        {
            _animator.SetBool(_Run1, false);
            _animator.SetBool(_Run2, false);
            _animator.SetBool(_Jump, false);
            _animator.SetBool(_Stop, true);
            _speed = 0;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            _animator.SetBool(_Run2, false);
            _animator.SetBool(_Stop, false);
            _animator.SetBool(_Run1, false);
            _animator.SetBool(_Jump, true);
            _rigidbody2D.AddForce(Vector2.up * _jumpForce);
            _reached?.Invoke();
        }
    }
}