using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public event Action OnJumpedAction;
    [SerializeField] private GameObject _playerView;
    [SerializeField] private SpawnController _spawnController;
    [SerializeField] private float _jumpForce = 1.5f;
    public bool IsSessionStarted = false;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = _playerView.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Jump();
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (IsSessionStarted != true)
            {
                _spawnController.EnableSpawn();
            }
            _rigidbody.velocity = Vector2.up * _jumpForce;
            EnableGravity();
            IsSessionStarted = true;

            OnJumpedAction?.Invoke();
        }
    }

    public void RestartPosition()
    {
        _playerView.transform.position = new Vector2(-.5f,.5f);
    }

    public void EnableGravity()
    {
        _rigidbody.gravityScale = 1;
    }

    public void DisableGravity()
    {
        _rigidbody.gravityScale = 0;
    }
    
}