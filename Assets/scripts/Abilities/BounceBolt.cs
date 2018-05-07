using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BounceBolt : Ability
{
    public float SpellSpeed = 8.0f;
    public int MaxBounces = 2;
    public int Damage = 5;
    public float ProjectileSpawnDistance = 0.25f;
    public int EnergyCost = 4;
    public float ActivationsPerSecond = 0.25f;

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

    public override float Activate(Transform transform, AbilityUser abilityUser, float lastActivationTime)
    {
        if (abilityUser.CanAffordAbility(EnergyCost) && ((Time.time - lastActivationTime) >= ActivationsPerSecond))
        {
            abilityUser.AdjustEnergy(-EnergyCost);

            Vector3 position = transform.position + (ProjectileSpawnDistance * transform.up);
            Quaternion rotation = transform.rotation;
            Instantiate(this, position, rotation);

            return Time.time;
        }

        return lastActivationTime;
    }
}
