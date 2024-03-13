using UnityEngine;
using TMPro;

public class PlayerView : MonoBehaviour
{
    [SerializeField] private GameStateController _gameStateController;
    [SerializeField] private PlayerController _playerController;
    private int _rotationSpeed;
    
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0,0,_playerController._rigidbody.velocity.y* _rotationSpeed);
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.transform.tag == "Obstacle")
        {
            _gameStateController.OpenEndGameView();
            _playerController.IsSessionStarted = false;
            gameObject.SetActive(false);
        } 

        if (collider.transform.tag == "Score")
        {
            _gameStateController._playerScore += 1;
        }

    }

}