using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BounceBolt : Ability
{
    public float SpellSpeed;
    public int MaxBounces;
    public int Damage;
    public float ProjectileSpawnDistance;
    public int EnergyCost;

    private Rigidbody2D Rigidbody2D;
    private int CurrentBounces;
    private Vector3 oldVelocity;

    private void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();

        var force = transform.up * SpellSpeed;
        Rigidbody2D.AddForce(force, ForceMode2D.Impulse);
    }

    private void FixedUpdate()
    {
        oldVelocity = Rigidbody2D.velocity;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Health health = other.gameObject.GetComponent<Health>();
        if (health != null)
        {
            health.AdjustHealth(-Damage);
        }

        if (CurrentBounces < MaxBounces)
        {
            Utils.Reflect(Rigidbody2D, transform, oldVelocity, other);
            CurrentBounces++;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public override void Activate(Transform transform, AbilityUser abilityUser)
    {
        if (abilityUser.CanAffordAbility(EnergyCost))
        {
            abilityUser.AdjustEnergy(-EnergyCost);

            var position = transform.position + (ProjectileSpawnDistance * transform.up);
            var rotation = transform.rotation;
            Instantiate(this, position, rotation);
        }
    }
}
