using UnityEngine;

public class RagdollHeadView : MonoBehaviour
{
    [SerializeField] private RagdollHeadView headView;
    [SerializeField] private Transform head;

    private Transform target;

    public void OnView(Transform target)
    {
        headView.enabled = true;
        this.target = target;
    }

    public void OffView()
    {
        headView.enabled = false;
        target = null;
    }

    private void Update()
    {
        Vector3 direction = Vector3.RotateTowards(head.forward, (target.position - head.position), 0.1f, 0.0f);
        head.rotation = Quaternion.LookRotation(direction);
    }
}
