using UnityEngine;

public class DistanceBetweenWashers : MonoBehaviour
{
    // Max distance between washers - 1.9f
    [SerializeField] private DistanceBetweenWashers distanceBetweenWashers;
    [SerializeField] private RagdollHand ragdollHand; 

    [SerializeField] private Transform firstWasher;
    [SerializeField] private Transform secondWasher;

    private float distance;

    private void Update()
    {
        distance = (secondWasher.position - firstWasher.position).magnitude;

        if (distance > 1.9f)
        {
            ragdollHand.DestroyHands();
            distanceBetweenWashers.enabled = false;
        }
    }

    public float GetDistance()
    {
        return distance;
    }
}
