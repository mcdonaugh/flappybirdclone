using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndGameScoreView : MonoBehaviour
{
    [SerializeField] private TMP_Text _endScoreTextUI;
    [SerializeField] private TMP_Text _bestScoreTextUI;
    [SerializeField] private ScoreController _scoreController;

    private void Update()
    {
        UpdateEndScoreUI(_scoreController.PlayerScore);
    }

    private void UpdateEndScoreUI(int score)
    {
        _endScoreTextUI.text = $"{score}";
    }
    
}
