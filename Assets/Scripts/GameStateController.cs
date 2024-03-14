using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameStateController : MonoBehaviour
{
    [SerializeField] private Transform _startGameView;
    [SerializeField] private Transform _gameView;
    [SerializeField] private Transform _endGameView;
    [SerializeField] private Transform _playerView;
    [SerializeField] private Transform _pauseGameView;
    [SerializeField] private PlayerController _playerController;
    [SerializeField] private SpawnController _spawnController;
    [SerializeField] private MedalView _medalView;
    
    private void Awake()
    {
        _playerController.gameObject.SetActive(false);
        _startGameView.gameObject.SetActive(true);
        _gameView.gameObject.SetActive(false);
        _endGameView.gameObject.SetActive(false);
        _playerView.gameObject.SetActive(false);
        _pauseGameView.gameObject.SetActive(false);
    }

    public void OpenGameView()
    {
        _playerController.gameObject.SetActive(true);
        _startGameView.gameObject.SetActive(false);
        _gameView.gameObject.SetActive(true);
        _endGameView.gameObject.SetActive(false);
        _playerView.gameObject.SetActive(true);
        _pauseGameView.gameObject.SetActive(false);
        _playerController.RestartPosition();
        _playerController.DisableGravity();
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        _gameView.gameObject.SetActive(false);
        _pauseGameView.gameObject.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        _gameView.gameObject.SetActive(true);
        _pauseGameView.gameObject.SetActive(false);
    }

    public void OpenEndGameView()
    {
        _playerController.gameObject.SetActive(false);
        _startGameView.gameObject.SetActive(false);
        _gameView.gameObject.SetActive(false);
        _endGameView.gameObject.SetActive(true);
        _pauseGameView.gameObject.SetActive(false);
        _spawnController.DestroyRemainingPipes();
        _spawnController.DisableSpawn();
        _playerController.RestartPosition();
        _playerController.DisableGravity();
        _medalView.AssignMedal();
    }

    public void RestartGame()
    {
        _spawnController.DestroyRemainingPipes();
        _startGameView.gameObject.SetActive(true);
        _gameView.gameObject.SetActive(false);
        _endGameView.gameObject.SetActive(false);
        _pauseGameView.gameObject.SetActive(false);
        _playerView.gameObject.SetActive(false);
        _playerController.RestartPosition();
        _medalView.RestartMedalDefault();
    }
}