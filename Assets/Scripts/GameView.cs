using UnityEngine;
using TMPro;


public class GameView : MonoBehaviour
{
    [SerializeField] private TMP_Text _playerScoreText;
    [SerializeField] private ScoreController _scoreController;

    private void Update()
    {
        UpdateScoreUI(_scoreController.PlayerScore);
    }

    private void UpdateScoreUI(int score)
    {
        _playerScoreText.text = $"{score}";
    }


    



}
