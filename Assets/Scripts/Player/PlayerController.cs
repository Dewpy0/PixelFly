using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float jumpForce;

    private Rigidbody2D _rb;
    private bool _pressJump;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _pressJump = true;
        }
    }

    void FixedUpdate()
    {
        if (_pressJump)
        {
            _rb.linearVelocity = new Vector2(_rb.linearVelocity.x, jumpForce);
            _pressJump = false;
        }
    }
}
