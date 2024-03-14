using UnityEngine;

public class ScoreController : MonoBehaviour
{
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
    private void OnScoreTriggerTouchedActionHandler()
    {
        PlayerScore += 1;
    }
}
