using UnityEngine;
using UnityEngine.UI;

public class MedalView : MonoBehaviour
{
    [SerializeField] private ScoreController _scoreController;
    [SerializeField] private Image _medalContainerImage;
    [SerializeField] private Sprite _bronzeMedalSprite;
    [SerializeField] private Sprite _silverMedalSprite;
    [SerializeField] private Sprite _goldMedalSprite;
    [SerializeField] private Sprite _platinumMedalSprite;

    public void AssignMedal()
    {
        if (_scoreController.PlayerScore >= 10)
        {
            _medalContainerImage.gameObject.SetActive(true);
            _medalContainerImage.sprite = _bronzeMedalSprite;
        }
        if (_scoreController.PlayerScore >= 20)
        {
            _medalContainerImage.sprite = _silverMedalSprite;
        }
        if (_scoreController.PlayerScore >= 30)
        {
            _medalContainerImage.sprite = _goldMedalSprite;
        }
        if (_scoreController.PlayerScore >= 40)
        {
            _medalContainerImage.sprite = _platinumMedalSprite;
        }
    }

    public void RestartMedalDefault()
    {
        _medalContainerImage.gameObject.SetActive(false);
    }
}