using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Reflect : MonoBehaviour
{
    public float Distance = 0.25f;
    public int EnergyCostPerTick = 5;
    public float TickLengthSeconds = 0.25f;
    
    public Transform CasterTransform { get; set; }
    public AbilityUser AbilityUser { get; set; }

    private Rigidbody2D Rigidbody2D;

    private void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();

        StartCoroutine("PayEnergyUpkeep");
    }

    private IEnumerator PayEnergyUpkeep()
    {
        while (true)
        {
            yield return new WaitForSeconds(TickLengthSeconds);
            if (AbilityUser.CanAffordAbility(EnergyCostPerTick))
            {
                AbilityUser.AdjustEnergy(-EnergyCostPerTick);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }

    private void LateUpdate()
    {
        if (CasterTransform == null)
        {
            Destroy(gameObject);
            return;
        }

        transform.SetPositionAndRotation(CasterTransform.position + (Distance * CasterTransform.up), CasterTransform.rotation);
    }
}
