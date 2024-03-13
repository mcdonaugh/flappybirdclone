using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject _playerView;
    [SerializeField] private SpawnController _spawnController;
    [SerializeField] private float _jumpForce = 10;
    public bool IsSessionStarted = false;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = _playerView.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Jump();
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (IsSessionStarted != true)
            {
                _spawnController.EnableSpawn();
                Debug.Log($"Spawner Started");
            }
            _rigidbody.AddForce(new Vector2(0,_jumpForce), ForceMode2D.Impulse);
            EnableGravity();
            IsSessionStarted = true;
        }
    }

    public void RestartPosition()
    {
        _playerView.transform.position = new Vector2(-.5f,.5f);
    }

    public void EnableGravity()
    {
        _rigidbody.gravityScale = 1;
        Debug.Log($"Gravity Enabled");
    }

    public void DisableGravity()
    {
        _rigidbody.gravityScale = 0;
        Debug.Log($"Gravity Disabled");
    }
    
}