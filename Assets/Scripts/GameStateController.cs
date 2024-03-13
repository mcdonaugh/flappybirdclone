using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class GameStateController : MonoBehaviour
{
    [SerializeField] private Transform _startGameView;
    [SerializeField] private Transform _gameView;
    [SerializeField] private Transform _endGameView;
    [SerializeField] private Transform _playerView;
    [SerializeField] private Transform _pauseGameView;
    [SerializeField] private PlayerController _playerController;
    [SerializeField] private SpawnController _spawnController;
    [SerializeField] private TMP_Text _playerScoreText;
    [SerializeField] private TMP_Text _playerEndText;
    [SerializeField] private TMP_Text _playerBestText;
    [SerializeField] private Transform _playerMedals;
    
    public int _playerScore;

    private void Awake()
    {
        _playerScore = 0;
        _startGameView.gameObject.SetActive(true);
        _gameView.gameObject.SetActive(false);
        _endGameView.gameObject.SetActive(false);
        _playerView.gameObject.SetActive(false);
        _pauseGameView.gameObject.SetActive(false);
        _playerMedals.GetChild(0).gameObject.SetActive(false);
        _playerMedals.GetChild(1).gameObject.SetActive(false);
        _playerMedals.GetChild(2).gameObject.SetActive(false);
        _playerMedals.GetChild(3).gameObject.SetActive(false);
    }

     private void Update()
    {
        SetScore(_playerScore);
    }

    public void OpenGameView()
    {
        _startGameView.gameObject.SetActive(false);
        _gameView.gameObject.SetActive(true);
        _endGameView.gameObject.SetActive(false);
        _playerView.gameObject.SetActive(true);
        _pauseGameView.gameObject.SetActive(false);
        _playerController.RestartPosition();
        _playerController.DisableGravity();
    }

    public void SetScore(int score)
    {
        _playerScoreText.text = $"{score}";
        _playerEndText.text = $"{score}";
        _playerBestText.text = $"{score}";
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
        _startGameView.gameObject.SetActive(false);
        _gameView.gameObject.SetActive(false);
        _endGameView.gameObject.SetActive(true);
        _pauseGameView.gameObject.SetActive(false);
        _spawnController.DisableSpawn();
        _playerController.RestartPosition();
        _playerController.DisableGravity();
        AssignMedal();
        
    }

    public void RestartGame()
    {
        _startGameView.gameObject.SetActive(true);
        _gameView.gameObject.SetActive(false);
        _endGameView.gameObject.SetActive(false);
        _pauseGameView.gameObject.SetActive(false);
        _playerView.gameObject.SetActive(false);
        _playerController.RestartPosition();
        SetScore(0);
    }

    private void AssignMedal()
    {
        if (_playerScore >= 10)
        {
            _playerMedals.GetChild(0).gameObject.SetActive(true);
        }
        if (_playerScore >= 20)
        {
            _playerMedals.GetChild(0).gameObject.SetActive(false);
            _playerMedals.GetChild(1).gameObject.SetActive(true);
        }
        if (_playerScore >= 30)
        {
            _playerMedals.GetChild(1).gameObject.SetActive(false);
            _playerMedals.GetChild(2).gameObject.SetActive(true);
        }
        if (_playerScore >= 40)
        {
            _playerMedals.GetChild(2).gameObject.SetActive(false);
            _playerMedals.GetChild(3).gameObject.SetActive(true);
        }
    }

}