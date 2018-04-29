using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BounceBolt : Ability
{
    public float SpellSpeed;
    public int MaxBounces;
    public int Damage;
    public float ProjectileSpawnDistance;

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
        if (other.gameObject.CompareTag(Tags.Wall))
        {
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
        //else if (other.gameObject.GetComponents<Health>())
        {
            //other.gameObject.GetComponent<PlayerController>().AdjustHealth(-Damage);
        }
    }

    public override void Activate(Transform transform)
    {
        var position = transform.position + (ProjectileSpawnDistance * transform.up);
        var rotation = transform.rotation;
        Instantiate(this, position, rotation);
    }
}
