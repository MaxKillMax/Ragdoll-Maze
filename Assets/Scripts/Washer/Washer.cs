using UnityEngine;

public class Washer : MonoBehaviour
{
    [SerializeField] private Rigidbody washerRigidbody;

    public void ToggleControl()
    {
        washerRigidbody.useGravity = !washerRigidbody.useGravity;
    }

    public void SetDirection(Vector3 touchPosition, float distanceBetweenWashers)
    {
        distanceBetweenWashers *= 2;
        float distance = (touchPosition - transform.position).magnitude;
        Vector3 direction = (touchPosition - transform.position) / distance;
        washerRigidbody.velocity = new Vector3(direction.x * (6 / distanceBetweenWashers), direction.y * (6 / distanceBetweenWashers), 0);
    }
}
