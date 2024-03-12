using UnityEngine;

public class PlayerView : MonoBehaviour
{
    [SerializeField] private GameStateController _gameStateController;
    [SerializeField] private PlayerController _playerController;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.transform.tag == "Obstacle")
        {
            _gameStateController.OpenEndGameView();
            _playerController.IsSessionStarted = false;
            Debug.Log($"Collided with: {collider.transform.name}");
            gameObject.SetActive(false);
        } 
    }
}