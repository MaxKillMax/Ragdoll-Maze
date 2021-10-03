using UnityEngine;

public class FinalTriggerController : MonoBehaviour
{
    [SerializeField] private GameObject winMenu;

    private int activatedTriggerCount;

    public void TriggerActivated()
    {
        activatedTriggerCount++;

        if (activatedTriggerCount == 2)
        {
            winMenu.SetActive(true);
        }
    }

    public void TriggerDeactivated()
    {
        activatedTriggerCount--;
    }
}
