using UnityEngine;

public class PlayerView : MonoBehaviour
{
    [SerializeField] private GameStateController _gameStateController;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        gameObject.SetActive(false);
        _gameStateController.OpenEndGameView();
        Debug.Log($"Touched Grass");
    }
}