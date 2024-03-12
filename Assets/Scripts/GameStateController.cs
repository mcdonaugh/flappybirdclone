using Unity.VisualScripting;
using UnityEngine;

public class GameStateController : MonoBehaviour
{
    [SerializeField] private Transform _startGameView;
    [SerializeField] private Transform _gameView;
    [SerializeField] private Transform _endGameView;
    [SerializeField] private Transform _playerView;
    [SerializeField] private PlayerController _playerController;
    [SerializeField] private SpawnController _spawnController;
    public int _playerScore = 0;
    

    private void Awake()
    {
        _startGameView.gameObject.SetActive(true);
        _gameView.gameObject.SetActive(false);
        _endGameView.gameObject.SetActive(false);
        _playerView.gameObject.SetActive(false);
    }

    public void OpenGameView()
    {
        _startGameView.gameObject.SetActive(false);
        _gameView.gameObject.SetActive(true);
        _endGameView.gameObject.SetActive(false);
        _playerView.gameObject.SetActive(true);
        _playerController.RestartPosition();
        _playerController.DisableGravity();
    }

    public void OpenEndGameView()
    {
        _startGameView.gameObject.SetActive(false);
        _gameView.gameObject.SetActive(false);
        _endGameView.gameObject.SetActive(true);
        _spawnController.DisableSpawn();
    }

    public void RestartGame()
    {
        _startGameView.gameObject.SetActive(true);
        _gameView.gameObject.SetActive(false);
        _endGameView.gameObject.SetActive(false);
        _playerView.gameObject.SetActive(false);
    }
}