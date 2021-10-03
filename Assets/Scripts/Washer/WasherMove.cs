using UnityEngine;

public class WasherMove : MonoBehaviour
{
    [SerializeField] private RagdollHeadView headView;
    [SerializeField] private DistanceBetweenWashers distanceBetweenWashers;
    private Washer movableWasher;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            
            if (Physics.Raycast(ray, out RaycastHit raycastHit))
            {
                if (touch.phase == TouchPhase.Began)
                {
                    if (raycastHit.collider.transform.TryGetComponent(out Washer washer) == true)
                    {
                        movableWasher = washer;

                        movableWasher.ToggleControl();
                        headView.OnView(raycastHit.collider.transform);
                    }
                }
                else if (touch.phase == TouchPhase.Ended)
                {
                    if (movableWasher != null)
                    {
                        movableWasher.ToggleControl();
                        headView.OffView();
                    }

                    movableWasher = null;
                }
                else if (movableWasher != null)
                {
                    movableWasher.SetDirection(raycastHit.point, distanceBetweenWashers.GetDistance());
                }
            }
        }
    }
}
