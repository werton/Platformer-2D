using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class GroundDetector : MonoBehaviour
{   
    private const float _castAngle = 0f;
    private const float _castDistance = .1f;

    [SerializeField] private LayerMask _groundLayer;

    private Collider2D _collider2D;

    public bool IsGrounded()
    {
        return Physics2D.BoxCast(_collider2D.bounds.center, _collider2D.bounds.size, _castAngle, Vector2.down, _castDistance, _groundLayer);
    }

    private void Awake()
    {
        _collider2D = GetComponent<Collider2D>();
    }
}