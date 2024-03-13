using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class PlayerView : MonoBehaviour
{
    [SerializeField] private GameStateController _gameStateController;
    [SerializeField] private PlayerController _playerController;
    [SerializeField] private SoundFXManager _soundFXManager;
    private float _rotationSpeed = 10f;
    
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0,0,_playerController._rigidbody.velocity.y * _rotationSpeed);
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.transform.tag == "Obstacle")
        {
            _soundFXManager._audioSource.PlayOneShot(_soundFXManager._getHit);
            _gameStateController.OpenEndGameView();
            _playerController.IsSessionStarted = false;
            gameObject.SetActive(false);
        } 

        if (collider.transform.tag == "Score")
        {
            _soundFXManager._audioSource.PlayOneShot(_soundFXManager._getPoints);
            _gameStateController._playerScore += 1;
        }

    }

}