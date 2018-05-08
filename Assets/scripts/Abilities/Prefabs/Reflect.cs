using System;
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
    private ReflectState ReflectState;

    private void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        ReflectState = ReflectState.Perfect; // TODO time down the reflect states

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
        transform.SetPositionAndRotation(CasterTransform.position + (Distance * CasterTransform.up), CasterTransform.rotation);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // TODO based on reflect state (bounce bolt should not need to know about reflects and vice versa)
    }
}
