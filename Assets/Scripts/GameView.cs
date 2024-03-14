using UnityEngine;
using TMPro;


public class GameView : MonoBehaviour
{
    [SerializeField] private TMP_Text _playerScoreText;
    [SerializeField] private PlayerView _playerView;
    
    public int PlayerScore{get; private set;}
    
    private void OnEnable()
    {
        _playerView.OnScoreTriggerTouchedAction += OnScoreTriggerTouchedActionHandler;
    }

    private void OnDisable()
    {
        _playerView.OnScoreTriggerTouchedAction -= OnScoreTriggerTouchedActionHandler;
    }

    private void UpdateScoreUI(int score)
    {
        _playerScoreText.text = $"{score}";
    }

    private void OnScoreTriggerTouchedActionHandler()
    {
        PlayerScore += 1;
        UpdateScoreUI(PlayerScore);
    }
    



}
