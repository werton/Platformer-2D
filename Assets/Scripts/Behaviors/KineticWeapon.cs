using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class KineticWeapon : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    public int GetDamage()
    {
        return (int)_rigidbody2D.velocity.sqrMagnitude;
    }

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
}