using UnityEngine;

public class RagdollHand : MonoBehaviour
{
    [SerializeField] private FixedJoint leftFixedJoint;
    [SerializeField] private FixedJoint rightFixedJoint;

    [SerializeField] private FixedJoint leftElbowFixedJoint;
    [SerializeField] private FixedJoint rightElbowFixedJoint;

    [SerializeField] private WasherMove washerMove;
    [SerializeField] private GameObject defeatMenu;

    private bool destroyed;

    private void Update()
    {
        if (leftFixedJoint == null || rightFixedJoint == null)
        {
            DestroyHands();
        }
    }

    public void DestroyHands()
    {
        if (destroyed == false)
        {
            Destroy(leftElbowFixedJoint);
            Destroy(rightElbowFixedJoint);

            Destroy(rightElbowFixedJoint);
            Destroy(leftElbowFixedJoint);

            destroyed = true;
            defeatMenu.SetActive(true);
            washerMove.enabled = false;
        }
    }
}
