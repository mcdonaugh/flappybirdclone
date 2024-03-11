using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using Unity.VisualScripting;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject _playerView;
    [SerializeField] private float _jumpForce = 10;
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
            _rigidbody.AddForce(new Vector2(0,_jumpForce), ForceMode2D.Impulse);
            Debug.Log($"Jumped");
        }
    }

    
}