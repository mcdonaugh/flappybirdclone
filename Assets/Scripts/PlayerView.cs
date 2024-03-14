using UnityEngine;
using TMPro;
using System;

public class PlayerView : MonoBehaviour
{
    public event Action OnScoreTriggerTouchedAction;
    [SerializeField] private GameStateController _gameStateController;
    [SerializeField] private PlayerController _playerController;
    private Rigidbody2D _rigidbody;

    private float _rotationSpeed = 10f;
    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0,0,_rigidbody.velocity.y * _rotationSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.transform.tag == "Obstacle")
        {
            //_soundFXManager.PlayAudio(_soundFXManager._getHit);
            _gameStateController.OpenEndGameView();
            _playerController.IsSessionStarted = false;
            gameObject.SetActive(false);
        } 

        if (collider.transform.tag == "Score")
        {
            OnScoreTriggerTouchedAction?.Invoke();
            //_gameStateController._playerScore += 1;
        }

    }

}