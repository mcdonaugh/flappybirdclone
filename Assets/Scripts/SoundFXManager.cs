using UnityEngine;

public class SoundFXManager : MonoBehaviour
{
    public AudioClip _getHit;
    [SerializeField] private AudioClip _getPoints;
    [SerializeField] private AudioClip _flapWings;
    [SerializeField] private PlayerController _playerController;
    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        Debug.Log(_audioSource);
    }

    private void OnEnable()
    {
        _playerController.OnJumpedAction += OnJumpActionHandler;
    }

    private void OnDisable()
    {
        _playerController.OnJumpedAction -= OnJumpActionHandler;
    }

    private void OnJumpActionHandler()
    {
        PlayAudio(_flapWings);
    }

    public void PlayAudio(AudioClip audioClip)
    {
        _audioSource.PlayOneShot(audioClip);
    }




}