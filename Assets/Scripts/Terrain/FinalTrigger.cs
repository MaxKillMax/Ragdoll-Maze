using UnityEngine;

public class FinalTrigger : MonoBehaviour
{
    [SerializeField] private FinalTriggerController triggerController;

    private bool activated;
    private bool secondActivated;

    private void Start()
    {
        if (triggerController == null)
        {
            Debug.LogError("Final is null!");
        }
    }

    // Two washer cannot enter the same trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Washer washer) == true)
        {
            if (!activated)
            {
                triggerController.TriggerActivated();
                activated = true;
            }
            else
            {
                secondActivated = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out Washer washer) == true)
        {
            if (!secondActivated)
            {
                triggerController.TriggerDeactivated();
                activated = false;
            }
            else
            {
                secondActivated = false;
            }
        }
    }
}
