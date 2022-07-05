using UnityEngine;
using UnityEngine.Events;

public class DamageableObject : MonoBehaviour
{
    [SerializeField] private int _health = 10;

    public event UnityAction DamageReceived;

    public event UnityAction Died;

    public bool IsAlive()
    {
        return _health > 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent<KineticWeapon>(out KineticWeapon weapon))
        {
            int damage = weapon.GetDamage();
            ReceiveDamage(damage);
        }
    }

    private void ReceiveDamage(int damageValue)
    {
        if (damageValue <= 0)
        {
            return;
        }

        _health = _health > damageValue ? (_health - damageValue) : 0;

        DamageReceived?.Invoke();

        if (_health == 0)
        {
            Died?.Invoke();
        }
    }
}