using UnityEngine;

public static class Utils
{
    public static void Reflect(Rigidbody2D rigidbody2D, Transform transform, Vector3 oldVelocity, Collision2D other)
    {
        ContactPoint2D contact = other.contacts[0];

        // reflect our old velocity off the contact point's normal vector
        Vector3 reflectedVelocity = Vector3.Reflect(oldVelocity, contact.normal);

        // assign the reflected velocity back to the rigidbody
        rigidbody2D.velocity = reflectedVelocity;
        // rotate the object by the same amount we changed its velocity
        Quaternion rotation = Quaternion.FromToRotation(oldVelocity, reflectedVelocity);
        transform.rotation = rotation * transform.rotation;
    }

    public static void CenterAboveUnit(Transform transform, Transform unit, float floatHeight)
    {
        transform.position = unit.position + (Vector3.up * floatHeight);
    }

    public static float Bound(this float num, float min, float max)
    {
        float boundedNum = Mathf.Max(num, min);
        boundedNum = Mathf.Min(boundedNum, max);

        return boundedNum;
    }
}
