using UnityEngine;
using TMPro;


public class GameView : MonoBehaviour
{
    [SerializeField] private TMP_Text _playerScore;
    [SerializeField] private GameStateController _gameStateController;
    
    private void Update()
    {
        SetScore(_gameStateController._playerScore);
    }

    public void SetScore(int score)
    {
        _playerScore.text = $"{score}";
    }



}
